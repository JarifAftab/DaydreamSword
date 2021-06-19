using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject bullet;
    public bool hitSaber;
    public Vector3 pastPosition;
    public Vector3 currentPosition;

    


    // Start is called before the first frame update
    void Start()
    {
        hitSaber = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    void ChangeBulletForce()
    {
        switch (PlayerController.lightSaberSelect)
        {
            case 0:
                currentPosition = LightsaberCollision.lukeBladeForward;
                break;
            case 1:
                currentPosition = LightsaberCollision.anakinBladeForward;
                break;
            case 2:
                currentPosition = LightsaberCollision.maulBladeForward;
                break;
        }

        Vector3 diff = currentPosition - pastPosition;
        diff = Vector3.Normalize(diff);
        bullet.GetComponent<Rigidbody>().AddForce(diff * 5000.0f);
        print("done");


    }
    */
    private void OnTriggerEnter(Collider other)
    {
        //print("Detected");
        if (other.gameObject.tag == "PlayerTag")
        {
            print("Delte object");
            Destroy(bullet);
        }
        else if (other.gameObject.tag == "SingleBladeLightsaber")
        {
            hitSaber = true;
            bullet.GetComponent<Rigidbody>().velocity = Vector3.zero;
            bullet.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
           
            if (PlayerController.lightSaberSelect == 0)
            {
                //pastPosition = LightsaberCollision.lukeBladeForward;
                //Invoke("ChangeBulletForce", 0.1f);
                bullet.GetComponent<Rigidbody>().AddForce(LightsaberCollision.lukeBladeForward * 500.0f);

            }
            else if (PlayerController.lightSaberSelect == 1)
            {
                //pastPosition = LightsaberCollision.anakinBladeForward;
                //Invoke("ChangeBulletForce", 1f);
                bullet.GetComponent<Rigidbody>().AddForce(LightsaberCollision.anakinBladeForward * 500.0f);
            }
            else if (PlayerController.lightSaberSelect == 2)
            {
                //pastPosition = LightsaberCollision.maulBladeForward;
                //Invoke("ChangeBulletForce", 0.1f);
                bullet.GetComponent<Rigidbody>().AddForce(LightsaberCollision.maulBladeForward*500.0f);
            }
            print("Hit the saber");
        }
        
    }
}
