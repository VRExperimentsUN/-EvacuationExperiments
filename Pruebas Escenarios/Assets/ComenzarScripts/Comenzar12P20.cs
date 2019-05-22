using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12P20 : MonoBehaviour {


	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {

		if(this.transform.position.z <= -16.73909 && this.transform.position.z >= -18.48334){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 
}
}