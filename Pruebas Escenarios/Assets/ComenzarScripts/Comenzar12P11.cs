using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12P11 : MonoBehaviour {


	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {

		if(this.transform.position.z <= -21.89416 && this.transform.position.z >= -22.99005){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 
	}
}
