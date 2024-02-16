using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    public Vector3 pointA;
    public Vector3 pointB;
    public float speed;

    private Vector3 currentTarget;
    
    void Start() {
        currentTarget = pointB;
    }
    
    void Update()
    {
        Vector3 toTarget = currentTarget - transform.position;
        Vector3 frameStep = toTarget.normalized * speed * Time.deltaTime;
        if(frameStep.magnitude > 0 && frameStep.magnitude < toTarget.magnitude) {
            transform.position += frameStep;
        }
        else{
            transform.position = currentTarget; //snap to target
            if(currentTarget == pointA) {
                currentTarget = pointB;
            } else {
                currentTarget = pointA;
            }
        }
    }
}
