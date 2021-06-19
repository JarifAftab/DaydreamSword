using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform enemyTransform;
    public Rigidbody rigidb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       enemyTransform.position = Vector3.MoveTowards(enemyTransform.position, PlayerController.currentLocation, 0.1f);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerTag")
        {
            print("Killed by enemy.");
        }
    }
}
