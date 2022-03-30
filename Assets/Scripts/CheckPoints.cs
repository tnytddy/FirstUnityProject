using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{

    public int checks = 0;

    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "CheckPoint") {
            Destroy(col.gameObject);
            checks = checks + 1;
            Debug.Log("Checks: " + checks);
        }
    }
    
}
