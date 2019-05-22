using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12PJ9 : MonoBehaviour {


	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {
		if(this.transform.position.z <= -24.4199  && this.transform.position.z >= -24.71643){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 

	}
}
