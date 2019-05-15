using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12P22 : MonoBehaviour {


	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {
		if(this.transform.position.z >= -20.047  && this.transform.position.z <= -18.800022){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 
		print("pj22: "+this.transform.position.z);
}
}