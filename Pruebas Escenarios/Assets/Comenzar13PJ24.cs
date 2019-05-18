using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comenzar13PJ24 : MonoBehaviour
{
    public Animator anim;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x <= -28.76 && this.transform.position.x>=-30.29)
        {
            anim.SetFloat("Empezar", 1.0f);
        }
        else
        {
            anim.SetFloat("Empezar", 0.0f);
        }
    }
}
