using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Fish can move");
    }

    // Update is called once per frame
    void Update()
    {
        System.Random rnd = new System.Random();
        int direction  = rnd.Next(1, 35);  // creates a number
        
if (direction == 2)
        {
            transform.Translate(Vector3.left * Time.deltaTime/10);
        }
else if (direction == 3)
        {
            transform.Translate(Vector3.up * Time.deltaTime/10);
        }
else if (direction == 4)
        {
            transform.Translate(Vector3.right * Time.deltaTime/10);
        }
else
        {
            transform.Translate(Vector3.down * Time.deltaTime/10);
        }

    }
}
