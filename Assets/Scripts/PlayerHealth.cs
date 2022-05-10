using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    
    //collision with enemy or lava invokes death

    private void OnCollisionEnter(Collision col) {

       if(col.gameObject.tag == "Enemy" || col.gameObject.tag == "Poison") {
           PlayerDeath();
        }


   }

   //function for death disables and enables things to prohibit player movement after death

   void PlayerDeath() {
       GetComponent<MeshRenderer>().enabled = false;
       GetComponent<Rigidbody>().isKinematic = true;
       GetComponent<PlayerMovement>().enabled = false;
       GetComponent<Shooting>().enabled = false;
       Invoke(nameof(Restart), 3.0f);

   }

    //invoke is used to make the scene appear with a delay, restart function gets name of the active scene

   void Restart() {

       SceneManager.LoadScene(SceneManager.GetActiveScene().name);

   }

}
