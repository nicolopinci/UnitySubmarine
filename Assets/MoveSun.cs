using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Sun can be rotated");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            transform.Rotate(0, 5, 0);
        }
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            transform.Rotate(0, -5 , 0);
        }
    }
}
