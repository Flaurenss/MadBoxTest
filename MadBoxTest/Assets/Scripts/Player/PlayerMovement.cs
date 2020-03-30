using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform[] paths;
    [SerializeField] private float playerSpeed = 0.3f;
    [SerializeField] private Transform playerBody;
    private bool endGame;
    private bool playerMoving = false;
    private bool movementAllowed;
    private bool deadState;
    private int actualPath;
    private float tValue;
    private Rigidbody playerRigidbody;
    private Vector3 originPos;
    private Quaternion originRotation;
    private WaitForEndOfFrame waitForEndOfFrame;
    private WaitForSeconds waitForSeconds;
    // Start is called before the first frame update
    void Start()
    {
        SaveOriginPos();
        actualPath = 0;
        tValue = 0f;
        movementAllowed = true;
        deadState = false;
        playerRigidbody = GetComponentInChildren<Rigidbody>();
        //Declaring here in order to avoid future allcations
        waitForEndOfFrame = new WaitForEndOfFrame();
        waitForSeconds = new WaitForSeconds(1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(!deadState && movementAllowed && !endGame)
        {
            StartCoroutine(ProgressPath(actualPath));
        }
    }

    public void Move(bool canMove)
    {
        if(!deadState && canMove && !endGame)
        {
            playerMoving = true;
        }
        else
        {
            playerMoving = false;
        }
    }

    IEnumerator ProgressPath(int path)
    {
        movementAllowed = false;
        Vector3 p0 = paths[path].GetChild(0).position;
        Vector3 p1 = paths[path].GetChild(1).position;
        Vector3 p2 = paths[path].GetChild(2).position;
        Vector3 p3 = paths[path].GetChild(3).position;

        while(tValue < 1)
        {
            if(playerMoving)
            {
                tValue += Time.deltaTime * playerSpeed;

                var newPosition = Mathf.Pow(1-tValue, 3) * p0
                + 3 * Mathf.Pow(1-tValue, 2) * tValue * p1
                + 3 * (1-tValue) * Mathf.Pow(tValue,2) * p2
                + Mathf.Pow(tValue,3) * p3;

                FaceDirection(newPosition);
                transform.position = newPosition;
            }
            yield return waitForEndOfFrame;
        }
        tValue = 0;
        movementAllowed = true;
        actualPath += 1;
        SaveOriginPos();
        if(actualPath > paths.Length -1)
        {
            endGame = true;
            //TODO end game
        }
    }
    /// <summary>
    /// Rotates the player to the direction that is going
    /// </summary>
    void FaceDirection(Vector3 newPos)
    {
        var faceDirection = newPos - transform.position;
        if(faceDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(faceDirection);
        }
    }

    void SaveOriginPos()
    {
        originPos = transform.position;
        originRotation = transform.rotation;
    }

    public void SetDead()
    {
        playerRigidbody.freezeRotation = false;
        deadState = true;
        // tValue = 0f;
        StartCoroutine(DeadCount());
    }

    IEnumerator DeadCount()
    {
        yield return waitForSeconds;
        //Reset parameters in order to start again from the current path
        ResetPlayer();
    }

    void ResetPlayer()
    {
        transform.position = originPos;
        transform.rotation = originRotation;
        playerRigidbody.velocity = Vector3.zero;
        playerBody.localPosition = new Vector3(0,1,0);
        playerBody.localRotation = Quaternion.identity;

        deadState = false;
        playerRigidbody.freezeRotation = true;
        tValue = 0f;
    }
}
