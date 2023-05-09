using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGun : MonoBehaviour {

    public Grappling grappling;

    private Quaternion desiredRotation;
    private float rotationSpeed = 5f;

    void Update() {
        if (!grappling.grappling)
        {
            desiredRotation = Quaternion.LookRotation(grappling.cam.forward);
            transform.rotation = Quaternion.LookRotation(grappling.cam.forward);
        }
           
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, Time.deltaTime * rotationSpeed);
            desiredRotation = Quaternion.LookRotation(grappling.grapplePoint - transform.position);
            
        }
        
    }

}
