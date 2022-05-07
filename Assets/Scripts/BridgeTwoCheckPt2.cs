using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTwoCheckPt2 : MonoBehaviour
{
    public int bridge_Checks = 0;
    public Material BridgeOneOff;
    public Material BridgeOneOn;
    private MeshRenderer check_color;

    private void Start() {

      check_color = GetComponent<MeshRenderer>();

    }

     private void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "Bullet") {
          Destroy(col.gameObject);
          check_color.material = BridgeOneOn;
          bridge_Checks = bridge_Checks + 1;
          Debug.Log("Checks: " + bridge_Checks);
          }
      }
}
