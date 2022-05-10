using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MimicPos : MonoBehaviour
{
    private void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "Player") {
            col.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision coll) {
        if(coll.gameObject.tag == "Player") {
            coll.gameObject.transform.SetParent(null);
    }

    }

    //all this does is change player to be child of object they collide with
}
