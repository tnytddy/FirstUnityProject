using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject gun;
    public GameObject bullet;
    public float bulletSpeed;
    public GameObject player;


    void Update()
    {
         if (Input.GetKeyDown("enter"))
        {
            
            GameObject ammo;
            ammo = Instantiate(bullet,gun.transform.position,gun.transform.rotation) as GameObject;

            //creates the bullets
            
            Rigidbody rb;
            rb = ammo.GetComponent<Rigidbody>();

            //adds rigidbody component
 
            
            rb.AddForce(player.transform.forward * bulletSpeed);

            //applies force to bullet to make it go forward
 
           
            Destroy(ammo, 1.5f);

            //destorys bullets after a 1.5 secs
        }
    }

}

