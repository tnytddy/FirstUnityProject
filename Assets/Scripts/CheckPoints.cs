using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{

    public int checks = 0;

    //four checks per level, once player collides with one then they are added up
    //four are needed in order to show the level exit

    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "CheckPoint") {
            Destroy(col.gameObject);
            checks = checks + 1;
            Debug.Log("Checks: " + checks);
        }
    }
    
}
