using UnityEngine;
using System.Collections;
 
public class Underwater : MonoBehaviour {
 
	//This script enables underwater effects. Attach to main camera.
 
    //Define variable
    public int underwaterLevel = 1000;
 
    //The scene's default fog settings
   private bool defaultFog; // = RenderSettings.fog;
    private Color defaultFogColor; // = RenderSettings.fogColor;
    private float defaultFogDensity; // = RenderSettings.fogDensity;
    private Material defaultSkybox; // = RenderSettings.skybox;
    private Material noSkybox;
 
    void Start () {
	    //Set the background color
	    GetComponent<Camera>().backgroundColor = new Color(0, 0.1f, 0.2f, 0.1f);
    }
 
    void Update () {
        if (transform.position.y < underwaterLevel)
        {
            RenderSettings.fog = true;
            RenderSettings.fogColor = new Color(0, 0.1f, 0.2f, 0.1f);
            RenderSettings.fogDensity = 0.001f;
            RenderSettings.skybox = noSkybox;
        }
        else
        {
            RenderSettings.fog = defaultFog;
            RenderSettings.fogColor = defaultFogColor;
            RenderSettings.fogDensity = defaultFogDensity;
            RenderSettings.skybox = defaultSkybox;
        }
    }
}
