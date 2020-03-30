using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// In charge of getting all the user inputs related to player movement
/// </summary>
public class InputController : MonoBehaviour
{
    private PlayerMovement movController;
    private void Awake() 
    {
        movController = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            movController.Move(true);
        }
        else
        {
            movController.Move(false);
        }
    }
}
