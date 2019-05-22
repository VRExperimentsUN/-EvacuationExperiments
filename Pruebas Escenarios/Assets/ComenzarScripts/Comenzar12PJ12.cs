using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12PJ12 : MonoBehaviour {


	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {

		if(this.transform.position.z <= -23.5573 && this.transform.position.z >= -24.18401){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 
	}
}
