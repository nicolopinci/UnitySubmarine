using UnityEngine;
using System.Collections;
 
public class addGravity : MonoBehaviour {
 
	//This script enables underwater effects. Attach to main camera.
 
    //Define variable
    public int underwaterLevel = -100;
 
    private Rigidbody rb;
 
    void Start () {
	    rb = GetComponent<Rigidbody>();
    }
 
    void Update () {
        if (transform.position.y < underwaterLevel)
        {
            Debug.Log("Gravity deactivated");
            rb.useGravity = false;
        }
        else
        {
            Debug.Log("Gravity activated");
            rb.useGravity = true;
        }
    }
}
