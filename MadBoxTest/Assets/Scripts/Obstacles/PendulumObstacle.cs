using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumObstacle : GenericObstacle
{
    [SerializeField] float maxAngle;
    [SerializeField] float pandulumSpeed;
    //Used to control the pendulum oscilation
    [SerializeField] float timePeriod;
    public override void ObstacleBehaviour()
    {
        float angle = maxAngle * Mathf.Sin( Time.time * pandulumSpeed/ timePeriod);
        transform.rotation = Quaternion.Euler( 0, 0, angle);
    }
}
