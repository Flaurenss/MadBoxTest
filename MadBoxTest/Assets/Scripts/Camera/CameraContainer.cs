using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//In charge of rotate camera when enter on triggers from camera change rotaion 
public class CameraContainer : MonoBehaviour
{
    Quaternion newRot;

    float speedMovement = 2;
    private void OnDisable()
    {
       CollisionDetector.OnTrigger -= ChangeTransform; 
    }
   private void Awake()
   {
       CollisionDetector.OnTrigger += ChangeTransform;
   }
    private void Start()
    {
        newRot = transform.rotation;
    }
    /// <summary>
    /// Updates the camera rotation depending on the newRot value
    /// </summary>
    private void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation,newRot,Time.deltaTime * speedMovement);
    }

    void ChangeTransform(Transform rot)
    {
        newRot = rot.rotation;
    }
}
