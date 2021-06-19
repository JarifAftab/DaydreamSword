using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Transform playerTransform;
    public Camera playerCamera;
    public Rigidbody playerDynamics;
    public static int abilitySelect = 0;
    public static int lightSaberSelect = 1;

    public static bool colourOveride = false;
    public static Color lightSaberColour = UnityEngine.Color.white;
    public static Vector3 currentLocation;

   

    void Start()
    {
        
        
    }

    void Update()
    {
        currentLocation = playerTransform.position;

        GvrControllerInputDevice controller = GvrControllerInput.GetDevice(GvrControllerHand.Right);
        if (GvrControllerInput.IsTouching) { 
        
            Vector3 touchPos = controller.TouchPos * 5;
           // print(touchPos);
            Vector3 velZ = playerCamera.transform.forward * touchPos.y;
            Vector3 velX = playerCamera.transform.right * touchPos.x;

            playerDynamics.velocity = velX + velZ;


        }
        else {
           
            playerDynamics.velocity = new Vector3(0, 0, 0);
        
        }

        if (controller.GetButtonDown(GvrControllerButton.App)) {

            abilitySelect++;
            if (abilitySelect> 2) {
                abilitySelect = 0;
            }

        }


    }
}
