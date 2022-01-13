using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Body_collision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            ResetState();
        }
        
    }

    private void ResetState()
    {
        Debug.Log("body touched");
    }
}
