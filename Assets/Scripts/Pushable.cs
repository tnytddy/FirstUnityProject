using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushable : MonoBehaviour
{

    private float forceAmt;

    //creates rigid body for box

    private void OnControllerEnter(Collision col) {
        Rigidbody box = col.collider.attachedRigidbody;


    //checks if boc object collided with is not null and that it is being touched by player

        if(box != null && col.gameObject.tag == "Player") {
            Vector3 forceDirection = col.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();
            box.AddForceAtPosition(forceDirection * forceAmt, transform.position, ForceMode.Impulse);
        }
    }

    //applies force to player in order to push the box
}
