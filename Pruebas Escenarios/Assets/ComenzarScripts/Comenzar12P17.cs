using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12P17 : MonoBehaviour {


	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {
		if(this.transform.position.z >= -23.42324  && this.transform.position.z <= -21.57902){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 
		print("pj17: "+this.transform.position.z);
}
}
