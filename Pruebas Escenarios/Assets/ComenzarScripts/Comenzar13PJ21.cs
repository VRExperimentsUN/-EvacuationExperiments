﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar13PJ21 : MonoBehaviour {
    public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x <= -29.76 && this.transform.position.x>=-31.10)
        {
            anim.SetFloat("Empezar", 1.0f);
        }
        else
        {
            anim.SetFloat("Empezar", 0.0f);
        }
	}
}
