﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarPjPuerta4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x <= -35)
        {
            Destruction();
        }
    }
    void Destruction()
    {
        Destroy(this.gameObject);
    }
}
