﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar14PJ34 : MonoBehaviour {
    public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x >= -4.03 && this.transform.position.x<=-3.09)
        {
            anim.SetFloat("Empezar", 1.0f);
        }
        else
        {
            anim.SetFloat("Empezar", 0.0f);
        }
	}
}
