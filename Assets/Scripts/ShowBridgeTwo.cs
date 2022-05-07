using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBridgeTwo : MonoBehaviour
{
    public BridgeTwoCheck script;
    public BridgeTwoCheckPt2 scriptTwo;

    void Update()
    {
        if(script.bridgeChecks >= 1 && scriptTwo.bridge_Checks >= 1) {
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<MeshCollider>().enabled = true;
        }
    }
}
