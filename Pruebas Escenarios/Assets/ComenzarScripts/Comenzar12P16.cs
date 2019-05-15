using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12P16 : MonoBehaviour {



	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {
		if(this.transform.position.z >= -24.731  && this.transform.position.z <= -24.43476){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 
		print("pj16: "+this.transform.position.z);
	}
}
