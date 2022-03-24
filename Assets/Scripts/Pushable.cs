using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushable : MonoBehaviour
{

    [SerializeField] private float forceAmt;

    private void OnControllerColliderHit(ControllerColliderHit collision) {
        Rigidbody box = collision.collider.attachedRigidbody;

        if(box != null) {
            Vector3 forceDirection = collision.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();
            box.AddForceAtPosition(forceDirection * forceAmt, transform.position, ForceMode.Impulse);
        }
    }
}
