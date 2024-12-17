using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public float velocidade = 10f;
   private Rigidbody2D rigidbody2D;
    void Start()
    {
       rigidbody2D = gameObject.GetComponent<Rigidbody2D>(); 
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody2D.AddForce(new Vector2(-velocidade,0));

            Debug.Log("LeftArrow");
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody2D.AddForce(new Vector2(velocidade,0));

            Debug.Log("RightArrow");
        }


    }
}
