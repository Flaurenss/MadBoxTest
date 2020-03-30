using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Generic class in charge of playing the Obstacle behaviour
/// </summary>
public abstract class GenericObstacle : MonoBehaviour
{
    void Update()
    {
        ObstacleBehaviour();
    }

    public abstract void ObstacleBehaviour();
}
