﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stupid_Zombie_Color : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer>().material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
