using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject camLock;
    Quaternion origRotation;
    public bool isWaving = false;
    Animator anim;

	// Use this for initialization
	void Start ()
    {
		if (camLock == null)
        {
            camLock = GameObject.Find("Camera Lock");
        }
        origRotation = camLock.transform.rotation;

        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0.0f, v);
        if (v != 0.0f || h != 0.0f)
        {
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Walking"))
                anim.Play("Walking");
            transform.rotation = Quaternion.LookRotation(movement);
        }
        else if (isWaving)
        {
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Waving"))
                anim.Play("Waving");
        }
        else
        {
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                anim.Play("Idle");
        }

        transform.Translate(movement * speed * Time.deltaTime, Space.World);


        camLock.transform.rotation = origRotation;
    }
}
