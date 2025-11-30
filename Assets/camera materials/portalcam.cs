using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalcam : MonoBehaviour
{
    public GameObject PlayerCameraOBJ;
    public Transform playerCamera;
    public Transform portal;
    public Transform otherPortal;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCamera == null)
        {
            GameObject camObj = GameObject.Find("PlayerCamera");
            if (camObj != null) playerCamera = camObj.transform;
        }

        // Correct rotation difference (includes required 180° flip)
        Quaternion rotationDifference =
            portal.rotation * Quaternion.Inverse(otherPortal.rotation);
            //Quaternion.Euler(0, 180f, 0);

        // POSITION
        Vector3 playerOffset = playerCamera.position - otherPortal.position;
        playerOffset = rotationDifference * playerOffset;
        transform.position = portal.position + playerOffset;

        // ROTATION
        transform.rotation = rotationDifference * playerCamera.rotation;
    }
}
