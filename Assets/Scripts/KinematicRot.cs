using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicRot : MonoBehaviour
{
    float maxSpeed = 5f; //speed of enemy
    public Transform player; //target
    Seek mySeek = new Seek();

    public Vector3 linearVelocity;
    public float angularVelocity;
 
    void Update()
    {
        transform.position += linearVelocity * Time.deltaTime;
        transform.eulerAngles += new Vector3(0, angularVelocity * Time.deltaTime, 0);

        KinematicSteeringOutput steering = mySeek.getSteering();


    }

}
