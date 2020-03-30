using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumObstacle : GenericObstacle
{
    [SerializeField] float maxAngle;
    [SerializeField] float pandulumSpeed;
    public override void ObstacleBehaviour()
    {
        float angle = maxAngle * Mathf.Sin( Time.deltaTime * pandulumSpeed);
        transform.rotation = Quaternion.Euler( 0, 0, angle);
    }
}
