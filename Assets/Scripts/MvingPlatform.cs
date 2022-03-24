using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MvingPlatform : MonoBehaviour
{
    [SerializeField] GameObject[] movingPoints;
    int index = 0;

    [SerializeField] float speed = 1f;
   
    void Update()
    {
        if(Vector3.Distance(transform.position, movingPoints[index].transform.position) < .1f) {
            index++;
            if(index >= movingPoints.Length) {
                index = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, movingPoints[index].transform.position, speed * Time.deltaTime);
    }
}
