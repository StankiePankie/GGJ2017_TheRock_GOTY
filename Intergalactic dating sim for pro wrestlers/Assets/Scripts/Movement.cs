using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject camLock;
    Quaternion origRotation;

	// Use this for initialization
	void Start ()
    {
		if (camLock == null)
        {
            camLock = GameObject.Find("Camera Lock");
        }
        origRotation = camLock.transform.rotation;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0.0f, v);
        if (v != 0.0f || h != 0.0f)
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }
        else
        {
            GetComponent<Animator>().Play("Idle");
        }

        transform.Translate(movement * speed * Time.deltaTime, Space.World);


        camLock.transform.rotation = origRotation;
    }
}
