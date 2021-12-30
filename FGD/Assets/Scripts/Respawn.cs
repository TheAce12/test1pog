using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.PlayerLoop;
using Object = UnityEngine.Object;

public class Respawn : MonoBehaviour
{
     public Transform playerpos;
     public Transform respawnPoint;

    private void OnTriggerEnter2D(Collider2D col)
    {
        playerpos.transform.position = respawnPoint.transform.position;
    }
}
