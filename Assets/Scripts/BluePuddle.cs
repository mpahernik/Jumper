﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePuddle : MonoBehaviour
{
   
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "GreenPlayer")
        {
            Destroy(other.gameObject);
        }

    }
}
