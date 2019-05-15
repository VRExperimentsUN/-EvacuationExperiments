using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12P10 : MonoBehaviour {


	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {
		if(this.transform.position.z >= -23.645511 && this.transform.position.z <= -22.70166){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 
		print ("pj10 " + this.transform.position.z);
	}
}
