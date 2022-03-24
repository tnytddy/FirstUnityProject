using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{

    int points = 0;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "Bullet") {
            points++;
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
