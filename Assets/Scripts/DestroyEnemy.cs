using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    int enemy_health = 3;
    int points = 0;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "Bullet") {
            enemy_health = enemy_health - 1;
            Destroy(col.gameObject);
            if (enemy_health == 0) {
            points = points + 5;
            Destroy(gameObject);
            }
        }
    }
}
