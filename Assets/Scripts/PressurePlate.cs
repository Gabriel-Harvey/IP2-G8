using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
  
    void Start()
    {
        
    }

    void Update()
    {

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {

            }
        }


    }
}
