using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12PJ32 : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {

		if(this.transform.position.z <= -27.5 && this.transform.position.z >= -29){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		}
	
	}
}
