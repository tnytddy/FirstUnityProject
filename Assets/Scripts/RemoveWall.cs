using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveWall : MonoBehaviour
{
    public DestroyBigEnemy script;
    public DestroyBigEnemyTwo scriptTwo;
   
    void Update()
    {
        if(script.enemys_remaining < 2 && scriptTwo.enemys_left < 1) {
            Destroy(gameObject);
        }
    }
}
