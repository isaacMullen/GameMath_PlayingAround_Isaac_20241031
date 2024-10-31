using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform target;
    float distanceBetween;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        
    }

    private void OnDrawGizmos()
    {                       
        if (distanceBetween < 5)
        {
            Gizmos.color = Color.red;
        }
        
        else
        {
            Gizmos.color = Color.blue;
        }
        
        Gizmos.DrawLine(transform.position, target.position);
        
        //Getting the target position only modifying the y value. keep x and z the same
        Vector3 targetPosition = new Vector3(target.position.x, transform.position.y, target.position.z);
        //Looking at that position
        transform.LookAt(targetPosition);

        distanceBetween = Vector3.Distance(transform.position, target.position);
    }
}
