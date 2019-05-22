using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12PJ23 : MonoBehaviour {
	

	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {

		if(this.transform.position.z <= -27.3 && this.transform.position.z >= -28.5){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		}
	}
}
