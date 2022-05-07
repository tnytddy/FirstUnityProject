using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBigEnemyTwo : MonoBehaviour
{
    int enemy_health = 10;
    public int points = 0;
    public int enemys_left = 1;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "Bullet") {
            enemy_health = enemy_health - 1;
            Destroy(col.gameObject);
            if (enemy_health == 0) {
            points = points + 15;
            enemys_left = enemys_left - 1;
            Destroy(gameObject);
            Debug.Log("Enemies: " + enemys_left);
            }
        }
    }
}
