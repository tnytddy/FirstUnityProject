using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowExit : MonoBehaviour
{
    public CheckPoints script;

    // checks if all four checks have been gathered before showing exit
    void Update()
    {
        if(script.checks >= 4) {
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
