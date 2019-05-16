using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12P20 : MonoBehaviour {


	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {
		if(this.transform.position.z >= -19.133 && this.transform.position.z <= -17.41845){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 
		print("pj20: "+this.transform.position.z);
}
}