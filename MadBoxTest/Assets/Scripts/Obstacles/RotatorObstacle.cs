using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorObstacle : GenericObstacle
{
    [SerializeField] private Vector3 rotation;
    public override void ObstacleBehaviour()
    {
        // var rot = rotatorSpeed * Time.deltaTime;
        transform.Rotate(rotation.x * Time.deltaTime, 
        rotation.y * Time.deltaTime
        , rotation.z * Time.deltaTime);
    }
}
