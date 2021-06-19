using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    public Renderer _renderer;
	public Camera characterCamera;

	
	
	// Start is called before the first frame update
	
	public void OnEnter(){
				
		_renderer.material.color = Color.red;
			
	}
	
	public void OnExit(){
		
		_renderer.material.color = Color.white;
		
	}
	
	public void OnGrab(){


		if (PlayerController.abilitySelect == 0)
		{
			gameObject.GetComponent<Rigidbody>().isKinematic = false;
			gameObject.GetComponent<Rigidbody>().AddForce(characterCamera.transform.forward * 1000.0f);

		}
		else if (PlayerController.abilitySelect == 1)
		{
			gameObject.GetComponent<Rigidbody>().isKinematic = false;
			gameObject.GetComponent<Rigidbody>().AddForce(characterCamera.transform.forward * -1000.0f);

		}
		else if(PlayerController.abilitySelect == 2) { 
			
			gameObject.GetComponent<Rigidbody>().isKinematic = true;
			Transform pointerTransform = GvrPointerInputModule.Pointer.PointerTransform;
			transform.SetParent(pointerTransform, true);
		}

		
        
		
		
		
	}
	
	public void OnRelease(){

		if (PlayerController.abilitySelect == 2) {

			transform.SetParent(null, true);
			gameObject.GetComponent<Rigidbody>().isKinematic = false;
		}
       


	}

	
    void Start()
    {
		
		_renderer = gameObject.GetComponent<Renderer>();
	  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
