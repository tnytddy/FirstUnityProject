using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBigEnemyTwo : MonoBehaviour
{
    int enemy_health = 10;
    public int enemys_left = 1;

    //Same as DestroyBigEnemy, but this one actually gets to 0. Same concept though.
    
    private void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "Bullet") {
            enemy_health = enemy_health - 1;
            Destroy(col.gameObject);
            if (enemy_health == 0) {
            enemys_left = enemys_left - 1;
            Destroy(gameObject);
            Debug.Log("Enemies: " + enemys_left);
            }
        }
    }
}
