using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12PJ9 : MonoBehaviour {


	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {
		if(this.transform.position.z >= -24.86206 && this.transform.position.z <= -24.53016){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 
		print("pj9: "+this.transform.position.z);
	}
}
