using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public delegate void CollisionDelegate();
    public static event CollisionDelegate OnCollision;
    public delegate void CollisionTriggerDelegate(Transform rot);
    public static event CollisionTriggerDelegate OnTrigger;

    private void OnCollisionEnter(Collision other)
    {
        if(other.transform.CompareTag("Obstacle"))
        {
            if(OnCollision != null)
            {
                OnCollision();
            }
        }    
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("CameraArea"))
        {
            if(OnTrigger != null)
            {
                OnTrigger(other.transform.parent.transform);
            }
        }
    }
}
