using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abrir : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Destruir", 45);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Destruir()
    {
        Destroy(this.gameObject);
    }
}
