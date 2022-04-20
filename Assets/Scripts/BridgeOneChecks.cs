using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeOneChecks : MonoBehaviour
{
   public int bridgeChecks = 0;
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
          bridgeChecks = bridgeChecks + 1;
          Debug.Log("Checks: " + bridgeChecks);
          }
      }
    
}
