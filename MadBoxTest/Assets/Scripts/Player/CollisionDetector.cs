using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public delegate void CollisionDelegate();
    public static event CollisionDelegate OnCollision;

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
}
