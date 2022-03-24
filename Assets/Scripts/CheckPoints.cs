using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{

    int checks = 0;

    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "CheckPoint") {
            Destroy(col.gameObject);
            checks++;
            Debug.Log("Active Checkpoints: " + checks);
        }
    }
    
}
