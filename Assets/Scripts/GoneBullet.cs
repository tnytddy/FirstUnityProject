using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoneBullet : MonoBehaviour
{
    //destroys the bullet in case it hits anything besides an enemy, since they would bounce off otherwise
   private void OnCollisionEnter (Collision collision) {
       if(collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Moving Box") {
       Destroy(gameObject);
       }
   }
}
