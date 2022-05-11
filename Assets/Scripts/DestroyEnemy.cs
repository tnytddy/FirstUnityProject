using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    int enemy_health = 3;

    // Code for all smaller enemies. Have three hits before they are dead. Can only
    //be destroyed by bullets
    private void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "Bullet") {
            enemy_health = enemy_health - 1;
            Destroy(col.gameObject);
            if (enemy_health == 0) {
            Destroy(gameObject);
            }
        }
    }
}
