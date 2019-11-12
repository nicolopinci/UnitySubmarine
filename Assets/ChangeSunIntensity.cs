using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSunIntensity : MonoBehaviour
{
    Light lt;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            lt.intensity++;
        }
if (Input.GetKeyDown("j"))
        {
            lt.intensity--;
        }
    }
}
