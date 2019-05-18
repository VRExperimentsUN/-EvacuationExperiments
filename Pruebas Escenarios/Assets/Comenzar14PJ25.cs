using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar14PJ25 : MonoBehaviour {
    public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x >= -5.17 && this.transform.position.x<=-4.29)
        {
            anim.SetFloat("Empezar", 1.0f);
        }
        else
        {
            anim.SetFloat("Empezar", 0.0f);
        }
	}
}
