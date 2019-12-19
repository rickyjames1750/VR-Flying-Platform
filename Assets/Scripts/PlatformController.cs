using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    // movement target 
    public Transform target;

    // speed
    public float speed = 1;

    // flag that sets wether we are moving or not
    bool isMoving = false;

    // Use this for initialization. Start is called before the first frame update.
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        // Check for input
        HandleInput();


        // Move our platform
        HandleMovement();
    }

    // take care of the movement
    void HandleMovement()
    {
        // calculate the distance from target
        float distance = Vector3.Distance(transform.position, target.position);

        // have we arrived?
        if (distance > 0)
        {

            // calculate how much we need to move (step) d = v * t
            float step = speed * Time.deltaTime;

            // move by that step
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }
}
