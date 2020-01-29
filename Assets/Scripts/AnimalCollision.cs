using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalCollision : MonoBehaviour
{
    public GameObject penguin;
    GameObject[] pengus;



    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            pengus = GameObject.FindGameObjectsWithTag("Enemy");

            if(pengus.Length < 3)
            {
                //Instantiate(penguin, penguin.transform);
            }
            
            //Set size
            
            //Set animator
        }
    }

    
}
