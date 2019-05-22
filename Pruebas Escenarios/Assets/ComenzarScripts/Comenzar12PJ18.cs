using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12PJ18 : MonoBehaviour {



	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {

		if(this.transform.position.z <= -21.86893 && this.transform.position.z >= -23.07292){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 
	}}
