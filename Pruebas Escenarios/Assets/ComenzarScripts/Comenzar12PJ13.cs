using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12PJ13 : MonoBehaviour {


	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {
		if(this.transform.position.z >= -23.971 && this.transform.position.z <= -22.74796){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 
		print("pj13: "+this.transform.position.z);
	}
}
