using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruidor : MonoBehaviour
{
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collider = collision.collider.gameObject;
        GameObject.Destroy (collider);
        // Se adicionar esse scrip na bolinha ela sai destruindo tudo que ela bate mt pucta
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
    	GameObject.Destroy(collider.gameObject);
    }
}
