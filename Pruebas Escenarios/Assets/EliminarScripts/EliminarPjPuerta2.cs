﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarPjPuerta2 : MonoBehaviour
{

    // Use this for initialization


    // Update is called once per frame
    void Update()
    {


        if (this.transform.position.z <= -40)
        {
            Destruction();
        }

    }

    void Destruction()
    {
        Destroy(this.gameObject);
    }
}
