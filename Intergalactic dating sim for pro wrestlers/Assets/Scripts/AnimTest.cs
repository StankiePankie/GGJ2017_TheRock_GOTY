using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTest : MonoBehaviour
{

    public string animClip = "Idle";
    Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();

        anim.Play(animClip);
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Simple calling convention for playing animations.
        // They MUST be in the Animator tree in the editor to 
        // be played properly.

        // TODO: figure out how to make one-off animations auto
        // transition back to default animation loop (Idle)

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            anim.Play("Bashful");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            anim.Play("Beckon");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            anim.Play("Excited");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            anim.Play("Idle");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            anim.Play("SadIdle");
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            anim.Play("SadWalk");
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            anim.Play("Walking");
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            anim.Play("Waving");
        }

    }

}
