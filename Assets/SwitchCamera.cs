using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{

    GameObject SubmarineCamera;
GameObject TopCamera;
    // Start is called before the first frame update
    void Start()
    {
          SubmarineCamera = GameObject.Find("SubmarineCamera");
          TopCamera = GameObject.Find("TopCamera");
    }



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp("1")) {
            SubmarineCamera.gameObject.SetActive(true);
            TopCamera.gameObject.SetActive(false);

         }
         else if (Input.GetKeyUp("2")) {
            SubmarineCamera.gameObject.SetActive(false);
            TopCamera.gameObject.SetActive(true);
         }
         
    }
}
