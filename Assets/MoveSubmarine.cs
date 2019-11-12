using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSubmarine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am alive");
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 100;

        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}
