using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBigEnemy : MonoBehaviour
{
    int enemy_health = 10;
    public int enemys_remaining = 2;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "Bullet") {
            enemy_health = enemy_health - 1;
            Destroy(col.gameObject);
            if (enemy_health == 0) {
            enemys_remaining = enemys_remaining - 1;
            Destroy(gameObject);
            Debug.Log("Enemies: " + enemys_remaining);
            }
        }
    }
}
