using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MimicPos : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "Capsule") {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision) {
        if(collision.gameObject.name == "Capsule") {
            collision.gameObject.transform.SetParent(null);
    }

    }
}
