using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12PJ34 : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {

		if(this.transform.position.z <= -26.88158 && this.transform.position.z >= -28.82417){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		}
	}
}
