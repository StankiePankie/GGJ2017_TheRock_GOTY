using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLights : MonoBehaviour
{
    public float speed = 45.0f;
    Light[] lights;
    int fadeDir = 1;
    float fadeTime = 0.0f;

	// Use this for initialization
	void Start ()
    {
        lights = new Light[GetComponentsInChildren<Light>().Length];
		for (int i = 0; i < lights.Length; ++i)
        {
            lights[i] = GetComponentsInChildren<Light>()[i];
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        fadeTime += Time.deltaTime * fadeDir;
        if (fadeTime > 2.0f || fadeTime < 0.0f)
        {
            fadeDir *= -1;
        }

        float r = Mathf.Lerp(0.2f, 1.2f, fadeTime / 2.0f);
        for (int i = 0; i < lights.Length; i++)
        {
            if (i % 2 == 0)
            {
                lights[i].intensity = r;
            }
            else
            {
                lights[i].intensity = -r;
            }
        }

        transform.Rotate(new Vector3(0, speed, 0));
	}
}
