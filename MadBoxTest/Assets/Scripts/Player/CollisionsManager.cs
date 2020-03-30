using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsManager : MonoBehaviour
{
    PlayerMovement playerMovement;

    private void OnDisable()
    {
        CollisionDetector.OnCollision -= Dead;    
    }

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        CollisionDetector.OnCollision += Dead;    
    }
    private void Dead()
    {
        playerMovement.SetDead();
    }
}
