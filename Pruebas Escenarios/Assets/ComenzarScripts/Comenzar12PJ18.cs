using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12PJ18 : MonoBehaviour {



	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {
		if(this.transform.position.z >= -23.23934  && this.transform.position.z <= -21.90856){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 
		print("pj18: "+this.transform.position.z);
	}}
