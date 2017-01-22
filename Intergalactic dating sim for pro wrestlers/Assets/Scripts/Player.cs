using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		//Sam: dummy stuff for now
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			Seduce(1);
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			Seduce(2);
		}

	}

	void Seduce(int waveType)
	{
		//Sam: dummy for now, don't use outside of round one
		Waifu mimi = GameObject.Find("Mimi").GetComponent<Waifu>();
		mimi.React(waveType);
	}

}
