using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalTextureSetup : MonoBehaviour
{
    public Camera cameraSnowy;
    public Material cameraMatSnowy;
    
    public Camera cameraMuseum;
    public Material cameraMatMuseum;

    public Camera cameraTiger;
    public Material cameraMatTiger;

    public Camera cameraMuseumTiger;
    public Material cameraMatMuseumTiger;
    
    public Camera cameraTurtle;
    public Material cameraMatTurtle;

    public Camera cameraMuseumTurtle;
    public Material cameraMatMuseumTurtle;
    
    public Camera cameraEagle;
    public Material cameraMatEagle;

    public Camera cameraMuseumEagle;
    public Material cameraMatMuseumEagle;


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
        
        
        if (cameraTiger.targetTexture != null)
        {
            cameraTiger.targetTexture.Release();
        }
        cameraTiger.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatTiger.mainTexture = cameraTiger.targetTexture;
        
        
        if (cameraMuseumTiger.targetTexture != null)
        {
            cameraMuseumTiger.targetTexture.Release();
        }
        cameraMuseumTiger.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatMuseumTiger.mainTexture = cameraMuseumTiger.targetTexture;

        if (cameraTurtle.targetTexture != null)
        {
            cameraTurtle.targetTexture.Release();
        }
        cameraTurtle.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatTurtle.mainTexture = cameraTurtle.targetTexture;

        if (cameraMuseumTurtle.targetTexture != null)
        {
            cameraMuseumTurtle.targetTexture.Release();
        }
        cameraMuseumTurtle.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatMuseumTurtle.mainTexture = cameraMuseumTurtle.targetTexture;
        
        if (cameraEagle.targetTexture != null)
        {
            cameraEagle.targetTexture.Release();
        }
        cameraEagle.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatEagle.mainTexture = cameraEagle.targetTexture;

        if (cameraMuseumEagle.targetTexture != null)
        {
            cameraMuseumEagle.targetTexture.Release();
        }
        cameraMuseumEagle.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatMuseumEagle.mainTexture = cameraMuseumEagle.targetTexture;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
