﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComenzarPJ46 : MonoBehaviour {
	public Animator anim;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (this.transform.position.z <= -16.8 && this.transform.position.z>=-17.5) {
			anim.SetFloat ("Empezar", 1.0f);
		} else {
			anim.SetFloat ("Empezar", 0.0f);
		}
	}
}
