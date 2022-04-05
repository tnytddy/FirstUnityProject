using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoneBullet : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnCollisionEnter (Collision collision) {
       if(collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Moving Box") {
       Destroy(gameObject);
       }
   }
}
