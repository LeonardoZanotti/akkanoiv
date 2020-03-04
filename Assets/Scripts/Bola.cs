using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
	public Vector2 velocidade;
    // Start is called before the first frame update
    void Start()
    {
     	Rigidbody2D rigidbody = GetComponent<Rigidbody2D> ();
    	// rigidbody.AddForce(new Vector2(10, 10)); --> Adicionar um valor fixo pro Vector2
    	rigidbody.AddForce(velocidade); 		// Valor variável que pode ser mudado dentro da Unity
    }
}
