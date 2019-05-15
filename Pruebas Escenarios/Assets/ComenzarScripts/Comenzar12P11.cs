using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12P11 : MonoBehaviour {


	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {
		if(this.transform.position.z >= -23.15941 && this.transform.position.z <= -21.91072){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 
		print("pj11: "+this.transform.position.z);
	}
}
