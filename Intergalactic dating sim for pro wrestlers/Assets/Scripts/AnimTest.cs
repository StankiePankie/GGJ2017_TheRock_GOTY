using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTest : MonoBehaviour
{

    public Animation anim;

	// Use this for initialization
	void Start ()
    {
		if (anim == null)
        {
            anim = GetComponent<Animation>();
        }
        anim.Play();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
