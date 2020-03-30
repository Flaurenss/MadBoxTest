using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorObstacle : GenericObstacle
{
    [SerializeField] private Vector3 rotation;
    public override void ObstacleBehaviour()
    {
        transform.Rotate(rotation.x * Time.deltaTime, 
        rotation.y * Time.deltaTime,
        rotation.z * Time.deltaTime);
    }
}
