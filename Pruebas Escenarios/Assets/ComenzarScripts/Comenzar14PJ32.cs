using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar14PJ32 : MonoBehaviour {
    public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.x >= -13.74 && this.transform.position.x<=-12.46) {
			anim.SetFloat ("Empezar", 1.0f);
		} else {
			anim.SetFloat ("Empezar", 0.0f);
		}
        print(this.transform.position.x + " PJ 32");
	}
}
