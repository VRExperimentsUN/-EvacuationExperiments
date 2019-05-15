using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar12PJ1 : MonoBehaviour {


	public Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.z >= -5.11 && this.transform.position.z <= -4.563){ 
			anim.SetFloat ("Empezar", 1.0f);
	

		}else{
		anim.SetFloat ("Empezar", 0.0f);
		
		}
		print ("pj1 " + this.transform.position.z);
	}
}
