using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorObstacle : GenericObstacle
{
    [SerializeField] private float rotatorSpeed;
    public override void ObstacleBehaviour()
    {
        var rotation = rotatorSpeed * Time.deltaTime;
        transform.Rotate(rotation, 0, 0);
    }
}
