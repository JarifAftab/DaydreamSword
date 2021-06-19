using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy : MonoBehaviour
{
    public Transform enemyTransform;
    public Rigidbody rigidb;
    public GameObject bolt;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 2f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        enemyTransform.position = Vector3.MoveTowards(enemyTransform.position, PlayerController.currentLocation, 0.0f);
        transform.LookAt(PlayerController.currentLocation);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerTag")
        {
            print("Killed by enemy.");
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bolt, transform.position+(0.1f* transform.forward), Quaternion.identity);
        bullet.transform.LookAt(PlayerController.currentLocation);
        //bullet.AddComponent(typeof(BulletController));
        //bullet.AddComponent(typeof(CapsuleCollider));
        bullet.GetComponent<BulletController>().bullet = bullet;
        //bullet.transform.rotation = Quaternion.Euler(bullet.transform.rotation.x+90, bullet.transform.rotation.y, bullet.transform.rotation.z);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 500.0f);
        print("Spawned bullet");
    }
}
