using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12P14 : MonoBehaviour {


	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {

		if(this.transform.position.z <= -21.27701 && this.transform.position.z >= -22.5986){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		}
	}
}
