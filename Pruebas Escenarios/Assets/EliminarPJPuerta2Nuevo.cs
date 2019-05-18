using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarPJPuerta2Nuevo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x >= 1)
        {
            Destruction();
        }
    }
    void Destruction()
    {
        Destroy(this.gameObject);
    }
}
