using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeOneChecksPt2 : MonoBehaviour
{
    public int bridge_Checks = 0;
    public Material BridgeOneOff;
    public Material BridgeOneOn;
    private MeshRenderer check_color;

    private void Start() {

      check_color = GetComponent<MeshRenderer>();

    }

    //works like the other bridge check. had to do two since it was two seperate objects to get the bridge
    //to appear

     private void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "Bullet") {
          Destroy(col.gameObject);
          check_color.material = BridgeOneOn;
          bridge_Checks = bridge_Checks + 1;
          Debug.Log("Checks: " + bridge_Checks);
          }
      }
}
