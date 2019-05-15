using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12P21 : MonoBehaviour {


	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {
		if(this.transform.position.z >= -19.764  && this.transform.position.z <= -18.4188){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 
		print("pj21: "+this.transform.position.z);
	}}

