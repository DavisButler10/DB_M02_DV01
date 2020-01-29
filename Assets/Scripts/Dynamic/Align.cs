using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Align : MonoBehaviour
{
    public Kinematic character;
    public Kinematic target;

    float maxAngularAcceleration = 100f;
    float maxRotation = 45f;

    float slowRadius = 10f;

    float timeToTarget = 0.1f;


    public virtual float getAngle()
    {
        return target.transform.eulerAngles.y;
    }

    public SteeringOutput getSteering()
    {
        SteeringOutput result = new SteeringOutput();


        float rotation = Mathf.DeltaAngle(character.transform.eulerAngles.y, getAngle());
        float rotationSize = Mathf.Abs(rotation);


        float myRotation = 0.0f;
        if (rotationSize > slowRadius)
        {
            myRotation = maxRotation;
        }
        else
        {
            myRotation = maxRotation * rotationSize / slowRadius;
        }


        myRotation *= rotation / rotationSize;


        float currentAngularVelocity = float.IsNaN(character.angularVelocity) ? 0f : character.angularVelocity;
        result.angularVelocity = myRotation - currentAngularVelocity;
        result.angularVelocity /= timeToTarget;

        float angularAcceleration = Mathf.Abs(result.angularVelocity);
        if (angularAcceleration > maxAngularAcceleration)
        {
            result.angularVelocity /= angularAcceleration;
            result.angularVelocity *= maxAngularAcceleration;
        }

        result.linearVelocity = Vector3.zero;
        return result;
    }
}
