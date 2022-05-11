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
    
    //checks if both big enemies have been defeated before removing wall allowing player to proceed
}
