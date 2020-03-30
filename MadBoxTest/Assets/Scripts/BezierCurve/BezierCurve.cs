using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Use of math formula from cubic bezier curve
/// </summary>
public class BezierCurve : MonoBehaviour
{
    [SerializeField] private List<GameObject> points = new List<GameObject>();
    private Vector3 gizmosPos;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        //Apply cubic bezier formula to draw the curves
        for(float t = 0; t<= 1; t+= 0.03f)
        {
            gizmosPos = Mathf.Pow(1-t, 3) * points[0].transform.position
            + 3 * Mathf.Pow(1-t, 2) * t * points[1].transform.position
            + 3 * (1-t) * Mathf.Pow(t,2) * points[2].transform.position
            + Mathf.Pow(t,3) * points[3].transform.position;

            Gizmos.DrawSphere(gizmosPos, 0.2f);
        }
        //Draw control points
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(points[0].transform.position, 0.3f);
        Gizmos.DrawSphere(points[3].transform.position, 0.3f);
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(points[1].transform.position, 0.3f);
        Gizmos.DrawSphere(points[2].transform.position, 0.3f);
        //Draw lines from anchor points from P1 to P2 and from P4 to P3
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector3(
            points[0].transform.position.x,
            points[0].transform.position.y,
            points[0].transform.position.z
            ),
            new Vector3(
            points[1].transform.position.x,
            points[1].transform.position.y,
            points[1].transform.position.z
            )
            );
        Gizmos.DrawLine(new Vector3(
            points[3].transform.position.x,
            points[3].transform.position.y,
            points[3].transform.position.z
            ),
            new Vector3(
            points[2].transform.position.x,
            points[2].transform.position.y,
            points[2].transform.position.z
            )
            );    
    }
}
