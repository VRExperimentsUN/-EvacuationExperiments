﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComenzarPJ28 : MonoBehaviour {
    public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.z <= -26.24 && this.transform.position.z >= -26.44)
        {
            anim.SetFloat("Empezar", 1.0f);
        }
        else {
            anim.SetFloat("Empezar", 0.0f);
        }
	}
}
