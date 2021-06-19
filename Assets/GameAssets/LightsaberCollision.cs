using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsaberCollision : MonoBehaviour
{

    public LineRenderer line;
    public Material lineMaterial;
    public int vertexCount;
    public bool created;

    public GameObject BladeTipLuke;
    public GameObject BladeEndLuke;

    public GameObject lukeForward;
    public static Vector3 lukeBladeForward;

    public GameObject BladeTipAnakin;
    public GameObject BladeEndAnakin;

    public GameObject anakinForward;
    public static Vector3 anakinBladeForward;

    public GameObject BladeTipMaulOne;
    public GameObject BladeTipMaulTwo;

    public GameObject maulForward;
    public static Vector3 maulBladeForward;

    public LayerMask mask;
    public GameObject BurnMark;

    // Start is called before the first frame update
    void Start()
    {
        created = false;
        
    }

   void OnTriggerEnter(Collider other)
    {
        //print("Detected");
        if (other.gameObject.tag == "SingleBladeLightsaber")
        {
            
        }
    }
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "SingleBladeLightsaber")
        {
            if (PlayerController.lightSaberSelect == 0) {
                RaycastHit hit = new RaycastHit();
                if (Physics.Raycast(BladeTipLuke.transform.position, BladeTipLuke.transform.forward, out hit, 10f, mask) || Physics.Raycast(BladeEndLuke.transform.position, BladeEndLuke.transform.forward, out hit, 2f, mask))
                {
                    //print("Burned");
                    //GameObject hole = Instantiate(BurnMark, hit.point, Quaternion.identity) as GameObject;
                    //hole.transform.LookAt(hit.point + hit.normal);

                    //So the issue is the lightSaber burn is determined by the tip of the saber. But we want
                    //the burn to show up on the surface to indicate to the user that an enemy has been hit

                    //So to do this we turn the ends of the saber into a vector, normazlie it and store it in a gameObject
                    Vector3 cast = new Vector3(BladeTipLuke.transform.position.x - BladeEndLuke.transform.position.x, BladeTipLuke.transform.position.y - BladeEndLuke.transform.position.y, BladeTipLuke.transform.position.z - BladeEndLuke.transform.position.z);
                    cast.Normalize();
                    GameObject castObject = new GameObject();
                    castObject.transform.position = BladeTipLuke.transform.position;

                    //Next we check if the tip is in the saber, if it is we keep moving the gameObject
                    //Along the lightSaber vector until it is just barely out of the enemy object, in other words,
                    //on the surface
                    if (gameObject.GetComponent<SphereCollider>().bounds.Contains(castObject.transform.position))
                    {
                        while (gameObject.GetComponent<SphereCollider>().bounds.Contains(castObject.transform.position))
                        {
                            castObject.transform.position -= cast * 0.01f;
                        }

                        //Now we can safely spawn the object
                        GameObject hole = Instantiate(BurnMark, castObject.transform.position, Quaternion.identity) as GameObject;
                        hole.transform.LookAt(hit.point + hit.normal);
                        //castObject.transform.position += hit.normal * 1.0f;



                        Destroy(hole, 5f);
                        Destroy(castObject, 5f);
                    }
                    else
                    {
                        
                        while (!gameObject.GetComponent<SphereCollider>().bounds.Contains(castObject.transform.position))
                        {
                            castObject.transform.position -= cast * 0.01f;
                        }
                        while (gameObject.GetComponent<SphereCollider>().bounds.Contains(castObject.transform.position))
                        {
                            castObject.transform.position -= cast * 0.01f;
                        }
                        
                        GameObject hole = Instantiate(BurnMark, castObject.transform.position, Quaternion.identity) as GameObject;
                        hole.transform.LookAt(hit.point + hit.normal);
                        //castObject.transform.position += hit.normal * 1.0f;



                        Destroy(hole, 5f);
                        Destroy(castObject, 5f);

                    }
                }
            }
            else if (PlayerController.lightSaberSelect == 1)
            {
                RaycastHit hit = new RaycastHit();
                if (Physics.Raycast(BladeTipAnakin.transform.position, BladeTipAnakin.transform.forward, out hit, 10f, mask) || Physics.Raycast(BladeEndAnakin.transform.position, BladeEndAnakin.transform.forward, out hit, 70f, mask))
                {
                    //print("Burned");
                    //GameObject hole = Instantiate(BurnMark, hit.point, Quaternion.identity) as GameObject;
                    //hole.transform.LookAt(hit.point + hit.normal);

                    //So the issue is the lightSaber burn is determined by the tip of the saber. But we want
                    //the burn to show up on the surface to indicate to the user that an enemy has been hit

                    //So to do this we turn the ends of the saber into a vector, normazlie it and store it in a gameObject
                    Vector3 cast = new Vector3(BladeTipAnakin.transform.position.x - BladeEndAnakin.transform.position.x, BladeTipAnakin.transform.position.y - BladeEndAnakin.transform.position.y, BladeTipAnakin.transform.position.z - BladeEndAnakin.transform.position.z);
                    cast.Normalize();
                    GameObject castObject = new GameObject();
                    castObject.transform.position = BladeTipAnakin.transform.position;

                    //Next we check if the tip is in the saber, if it is we keep moving the gameObject
                    //Along the lightSaber vector until it is just barely out of the enemy object, in other words,
                    //on the surface
                    if (gameObject.GetComponent<SphereCollider>().bounds.Contains(castObject.transform.position))
                    {
                        while (gameObject.GetComponent<SphereCollider>().bounds.Contains(castObject.transform.position))
                        {
                            castObject.transform.position -= cast * 0.01f;
                        }

                        //Now we can safely spawn the object
                        GameObject hole = Instantiate(BurnMark, castObject.transform.position, Quaternion.identity) as GameObject;
                        hole.transform.LookAt(hit.point + hit.normal);
                        //castObject.transform.position += hit.normal * 1.0f;



                        Destroy(hole, 5f);
                        Destroy(castObject, 5f);
                    }
                    else
                    {
                        
                        while (!gameObject.GetComponent<SphereCollider>().bounds.Contains(castObject.transform.position))
                        {
                            castObject.transform.position -= cast * 0.01f;
                        }
                        while (gameObject.GetComponent<SphereCollider>().bounds.Contains(castObject.transform.position))
                        {
                            castObject.transform.position -= cast * 0.01f;
                        }
                        
                        GameObject hole = Instantiate(BurnMark, castObject.transform.position, Quaternion.identity) as GameObject;
                        hole.transform.LookAt(hit.point + hit.normal);
                        //castObject.transform.position += hit.normal * 1.0f;



                        Destroy(hole, 5f);
                        Destroy(castObject, 5f);

                    }
                }
            }
        
            if (PlayerController.lightSaberSelect == 2)
            {
                RaycastHit hit = new RaycastHit();
                if (Physics.Raycast(BladeTipMaulOne.transform.position, BladeTipMaulOne.transform.forward, out hit, 10f, mask) || Physics.Raycast(BladeTipMaulTwo.transform.position, BladeTipMaulTwo.transform.forward, out hit, 70f, mask))
                {
                    //print("Burned");
                    //GameObject hole = Instantiate(BurnMark, hit.point, Quaternion.identity) as GameObject;
                    //hole.transform.LookAt(hit.point + hit.normal);

                    //So the issue is the lightSaber burn is determined by the tip of the saber. But we want
                    //the burn to show up on the surface to indicate to the user that an enemy has been hit

                    //So to do this we turn the ends of the saber into a vector, normazlie it and store it in a gameObject
                    Vector3 cast = new Vector3(BladeTipMaulOne.transform.position.x-BladeTipMaulTwo.transform.position.x, BladeTipMaulOne.transform.position.y - BladeTipMaulTwo.transform.position.y, BladeTipMaulOne.transform.position.z - BladeTipMaulTwo.transform.position.z);
                    cast.Normalize();
                    GameObject castObject = new GameObject();
                    castObject.transform.position=BladeTipMaulOne.transform.position;

                    //Next we check if the tip is in the saber, if it is we keep moving the gameObject
                    //Along the lightSaber vector until it is just barely out of the enemy object, in other words,
                    //on the surface
                    if (gameObject.GetComponent<SphereCollider>().bounds.Contains(castObject.transform.position)) {
                        while (gameObject.GetComponent<SphereCollider>().bounds.Contains(castObject.transform.position))
                        {
                            castObject.transform.position -= cast * 0.01f;
                        }

                        //Now we can safely spawn the object
                        GameObject hole = Instantiate(BurnMark, castObject.transform.position, Quaternion.identity) as GameObject;
                        hole.transform.LookAt(hit.point + hit.normal);
                        //castObject.transform.position += hit.normal * 1.0f;



                        Destroy(hole, 5f);
                        Destroy(castObject, 5f);
                    }
                    else
                    {
                        print("Printed-1");
                        while (!gameObject.GetComponent<SphereCollider>().bounds.Contains(castObject.transform.position))
                        {
                            castObject.transform.position -= cast * 0.01f;
                        }
                        while (gameObject.GetComponent<SphereCollider>().bounds.Contains(castObject.transform.position))
                        {
                            castObject.transform.position -= cast * 0.01f;
                        }
                        print("Printed-2");
                        GameObject hole = Instantiate(BurnMark, castObject.transform.position, Quaternion.identity) as GameObject;
                        hole.transform.LookAt(hit.point + hit.normal);
                        //castObject.transform.position += hit.normal * 1.0f;
                       


                        Destroy(hole, 5f);
                        Destroy(castObject, 5f);

                    }
                }
            }
        }

    }
    void OnTriggerExit(Collider other)
    {
        //print("Detected");
        if (other.gameObject.tag == "SingleBladeLightsaber")
        {
            //print("Lightsaber");
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        lukeBladeForward = lukeForward.transform.forward;
        anakinBladeForward = anakinForward.transform.forward;
        maulBladeForward = maulForward.transform.forward;
    }
}
