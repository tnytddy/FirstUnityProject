using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    public CheckPoints script;

    private void OnTriggerEnter(Collider col) {

        if(col.gameObject.tag == "Player") {
            if(GetComponent<MeshRenderer>().enabled == true)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        

    }

    //checks if mesh renderer is on before allowing player to go to next level, otherwise they could go through
    //even if the exit isnt visible    
}
