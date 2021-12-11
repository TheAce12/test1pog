using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capcanadmg : MonoBehaviour
{
    public Transform inamicPoint;
    public float inamicRange = 0.5f;
    public LayerMask enemyLayer;
    void Update()
    {
    Collider2D[] enemieshit = Physics2D.OverlapCircleAll(inamicPoint.position, inamicRange, enemyLayer);
        
        foreach(Collider2D enemy in enemieshit){
            Destroy(gameObject);
            Debug.Log("Este atacat");
        }
    }
    void OnDrawGizmosSelected()
    {
        if (inamicPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(inamicPoint.position, inamicRange);
    }
}
