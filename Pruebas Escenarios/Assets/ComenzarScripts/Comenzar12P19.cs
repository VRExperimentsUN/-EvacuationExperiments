using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12P19 : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {

	}

	void Update () {
		if(this.transform.position.z >= -19.02987 && this.transform.position.z <= -17.37416){ 
			anim.SetFloat ("Empezar", 1.0f);


		}else{
			anim.SetFloat ("Empezar", 0.0f);

		} 
		print("pj19: "+this.transform.position.z);
}
}
