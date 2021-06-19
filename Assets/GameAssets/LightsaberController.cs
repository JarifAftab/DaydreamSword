using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsaberController : MonoBehaviour
{
    public GameObject Luke;
    public GameObject Anakin;
    public GameObject Maul;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerController.lightSaberSelect == 0) {

            Luke.SetActive(true);
            Anakin.SetActive(false);
            Maul.SetActive(false);

        }
        else if (PlayerController.lightSaberSelect == 1)
        {

            Luke.SetActive(false);
            Anakin.SetActive(true);
            Maul.SetActive(false);

        }
        else if (PlayerController.lightSaberSelect == 2)
        {

            Luke.SetActive(false);
            Anakin.SetActive(false);
            Maul.SetActive(true);

        }


    }
}
