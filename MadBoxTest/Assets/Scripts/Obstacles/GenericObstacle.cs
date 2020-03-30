using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericObstacle : MonoBehaviour
{
    void Update()
    {
        ObstacleBehaviour();
    }

    public abstract void ObstacleBehaviour();
}
