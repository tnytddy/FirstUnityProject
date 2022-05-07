using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowExit : MonoBehaviour
{
    public CheckPoints script;

    // Update is called once per frame
    void Update()
    {
        if(script.checks >= 4) {
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
