using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar14PJ31 : MonoBehaviour {
    public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.x >= -14.13 && this.transform.position.x<=-12.99)
        {
            anim.SetFloat("Empezar", 1.0f);
        }
        else
        {
            anim.SetFloat("Empezar", 0.0f);
        }
        print(this.transform.position.x + " PJ 31");
	}
}
