using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerObstacle : GenericObstacle
{
    [SerializeField] private float speed;
    [SerializeField] private float backSpeed;
    [SerializeField] private int finalDegree;
    [SerializeField] private int originDegree;
    bool goComplete = false;
    bool backComplete = true;
    public override void ObstacleBehaviour()
    {
        if(!goComplete)
        {
            transform.Rotate(0,0,speed * Time.deltaTime);
            if(transform.eulerAngles.z < finalDegree)
            {
                goComplete = true;
                backComplete = false;
            }
        }
        else if(!backComplete)
        {
            transform.Rotate(0,0,backSpeed * Time.deltaTime);
            if(transform.eulerAngles.z > originDegree)
            {
                backComplete = true;
                goComplete = false;
            }
        }
    }
}
