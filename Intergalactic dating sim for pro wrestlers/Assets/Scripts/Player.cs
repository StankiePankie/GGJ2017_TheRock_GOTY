using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	//public float rayDistance;
	List<Waifu> nearby;
    public GameObject lovePower;
    Movement move;

	// Use this for initialization
	void Start()
	{
		nearby = new List<Waifu>();
        move = GetComponent<Movement>();
	}

	// Update is called once per frame
	void Update()
	{
		
		//Sam: dummy stuff for now
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			Seduce(1);
            move.isWaving = true;
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			Seduce(2);
            move.isWaving = true;
		}
        if (Input.GetKeyUp(KeyCode.Alpha1) && Input.GetKeyUp(KeyCode.Alpha2))
        {
            move.isWaving = false;
        }

	}

	void Seduce(int waveType)
	{
        GetComponent<Animator>().Play("Waving");
		foreach (Waifu babe in nearby)
		{
			Vector3 rockFwd = transform.TransformDirection(Vector3.forward);
			Vector3 babeFwd = babe.gameObject.transform.TransformDirection(Vector3.forward);
			if (Vector3.Dot(rockFwd, babeFwd) < 0.0f)
            {
                Object powerOfLove = Instantiate(lovePower, new Vector3(transform.position.x, transform.position.y + 2.0f, transform.position.z), Quaternion.identity);
                Destroy(powerOfLove, 1.0f);

                babe.React(waveType);
            }
		}
		//Waifu mimi = GameObject.Find("Mimi").GetComponent<Waifu>();
		//mimi.React(waveType);
	}

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("Collision Detected!");

		Waifu waifu = other.gameObject.GetComponent<Waifu>();
		if(waifu != null)
		{
			Debug.Log("Waifu found!");
			nearby.Add(waifu);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		Waifu waifu = other.gameObject.GetComponent<Waifu>();
		if(waifu != null)
		{
			if (nearby.Contains(waifu))
			{
				nearby.Remove(waifu);
				Debug.Log("Waifu lost!");
			}
		}
	}

}
