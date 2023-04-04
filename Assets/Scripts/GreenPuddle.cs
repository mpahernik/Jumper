using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPuddle : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "BluePlayer")
        {
            Destroy(other.gameObject);
        }

    }

}
