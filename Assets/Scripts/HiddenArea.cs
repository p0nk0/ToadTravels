using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenArea : MonoBehaviour
{
    public Camera camera;
    int mymask;
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other) //if a collider entered the trigger
    {
        if (other.gameObject.CompareTag("Player")) //if that collider was a player
        {
            mymask = camera.cullingMask; //sets the current camera to a variable
            camera.cullingMask = 1 << 0; //hides the secret wall from the camera
        }
        
    }
}
