using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar14PJ26 : MonoBehaviour {
    public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x >= -6.35 && this.transform.position.x<=-5.47)
        {
            anim.SetFloat("Empezar", 1.0f);
        }
        else
        {
            anim.SetFloat("Empezar", 0.0f);
        }
        print(this.transform.position.x + " PJ 26");
	}
}
