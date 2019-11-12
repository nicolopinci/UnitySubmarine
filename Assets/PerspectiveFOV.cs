using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerspectiveFOV : MonoBehaviour
{

   // Camera[] allC = Camera.allCameras;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
if (Input.GetKeyUp("f")) {
           foreach(Camera c in Camera.allCameras) {

                c.fieldOfView++;
            }
}
else if (Input.GetKeyUp("v")) {
           foreach(Camera c in Camera.allCameras) {
                c.fieldOfView--;
            }
}
    }
}
