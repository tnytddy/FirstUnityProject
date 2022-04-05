using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
   private void OnCollisionEnter(Collision col) {

       if(col.gameObject.tag == "Enemy" || col.gameObject.tag == "Poison") {
           Death();
       }

   }

   void Death() {

       GetComponent<MeshRenderer>().enabled = false;
       GetComponent<Rigidbody>().isKinematic = true;
       GetComponent<PlayerMovement>().enabled = false;
       GetComponent<Shooting>().enabled = false;
       Invoke(nameof(LevelRestart), 3.0f);

   }

   void LevelRestart() {

       SceneManager.LoadScene(SceneManager.GetActiveScene().name);

   }
}
