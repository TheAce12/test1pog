using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capcanadmg : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Square (4)"){
            Destroy(gameObject);
        }
    }
}
