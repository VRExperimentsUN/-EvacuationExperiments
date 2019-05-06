using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarPuerta3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.z <= -34) {
            Destruir();
        }
	}
    public void Destruir() {
        Destroy(this.gameObject);
    }
}
