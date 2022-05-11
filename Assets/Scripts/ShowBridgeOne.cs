using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBridgeOne : MonoBehaviour
{

    public BridgeOneChecks script;
    public BridgeOneChecksPt2 scriptTwo;

    void Update()
    {
        if(script.bridgeChecks >= 1 && scriptTwo.bridge_Checks >= 1) {
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<MeshCollider>().enabled = true;
        }
    }

    //checks if both bridge checks are active then allows player to see and walk on bridge
}
