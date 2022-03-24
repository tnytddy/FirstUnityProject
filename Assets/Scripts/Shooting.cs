using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletEmitter;
    public GameObject bullet;
    public float bulletSpeed;
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
         if (Input.GetKeyDown("enter"))
        {
            
            GameObject Bullet_Handler;
            Bullet_Handler = Instantiate(bullet,bulletEmitter.transform.position,bulletEmitter.transform.rotation) as GameObject;
 
            
            Bullet_Handler.transform.Rotate(Vector3.left * 90);
 
            
            Rigidbody Temp_rb;
            Temp_rb = Bullet_Handler.GetComponent<Rigidbody>();
 
            
            Temp_rb.AddForce(player.transform.forward * bulletSpeed);
 
           
            Destroy(Bullet_Handler, 1.5f);
        }
    }

}

