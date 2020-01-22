using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek 
{
    public KinematicRot character;
    public GameObject target;

    float maxAcceleration;

    public KinematicSteeringOutput getSteering()
    {
        KinematicSteeringOutput result = new KinematicSteeringOutput();


        result.velocityLinear = target.transform.position - character.transform.position;

        result.velocityLinear.Normalize();
        result.velocityLinear *= maxAcceleration;

        return result;
    }

}
