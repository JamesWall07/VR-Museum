using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalTextureSetup : MonoBehaviour
{
    public Camera cameraSnowy;
    public Material cameraMatSnowy;
    
    public Camera cameraMuseum;
    public Material cameraMatMuseum;
    // Start is called before the first frame update
    void Start()
    {
        if (cameraSnowy.targetTexture != null)
        {
            cameraSnowy.targetTexture.Release();
        }
        cameraSnowy.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatSnowy.mainTexture = cameraSnowy.targetTexture;
        
        if (cameraMuseum.targetTexture != null)
        {
            cameraMuseum.targetTexture.Release();
        }
        cameraMuseum.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatMuseum.mainTexture = cameraMuseum.targetTexture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
