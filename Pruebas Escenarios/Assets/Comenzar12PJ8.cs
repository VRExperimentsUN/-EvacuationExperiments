﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12PJ8 : MonoBehaviour {



	public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.z >= -3.95 && this.transform.position.z <= -3.482){ 
			anim.SetFloat ("Empezar", 1.0f);


			}else{
				anim.SetFloat ("Empezar", 0.0f);

		}

		print ("pj8 " + this.transform.position.z);
	}
}
