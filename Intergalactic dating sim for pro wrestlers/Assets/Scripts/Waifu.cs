﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waifu : MonoBehaviour
{
	//Sam: the number the Rock needs to win her over (in the real world this number is 0)
	public float toSeduce;
	//Sam: how seduced is she? also this doesn't feel rapey at all
	float seductionRating;
	//Sam: the waves we need to attract waifu
	public int[] wavePattern;
	//Sam: what's the current wave we need?
	int currWave;

	public float waveTimer;

	// Use this for initialization
	void Start()
	{
		//not seduced yo
		seductionRating = 0.0f;
	}

	// Update is called once per frame
	void Update()
	{
		if (waveTimer > 0.0f)
		{
			waveTimer -= Time.deltaTime;
			if (waveTimer <= 0.0f)
			{
				seductionRating = 0.0f;
				waveTimer = 0.0f;

				Debug.Log("SHE'S GOING FOR THE MACE! Seduced: " + seductionRating.ToString());
			}

			//Debug.Log("WaveTimer: " + waveTimer.ToString());
		}
	}

	//react?
	public void React(int waveType)
	{
		//does waveType match currWave? Y: seduced+ N: seduced-
		if (waveType == wavePattern[currWave])
		{
			seductionRating += 10.0f;
			currWave++;
			if (currWave > wavePattern.Length - 1)
				currWave = 0;
			waveTimer = 5.0f; //arbitrary number

			Debug.Log("Hey Sexy! Seduced: " + seductionRating.ToString());
		}
		else
		{
			seductionRating -= 10.0f;
			Debug.Log("Fuck off creep! Seduced: " + seductionRating.ToString());
		}
	}
}
