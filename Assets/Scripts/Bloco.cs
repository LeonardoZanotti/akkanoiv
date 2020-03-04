using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{	
	public Rigidbody2D rigidbody;
	public BoxCollider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D> ();
    	collider = GetComponent<BoxCollider2D> ();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbody.constraints = new RigidbodyConstraints2D ();
        collider.isTrigger = true;
    }
}
