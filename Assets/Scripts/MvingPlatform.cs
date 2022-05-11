using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MvingPlatform : MonoBehaviour
{
    [SerializeField] GameObject[] points;
    int i = 0;

    [SerializeField] float speed = 1f;

    //sets up array to hold points that the platform will bounce between and set speed 
   
    void Update()
    {
        if(Vector3.Distance(transform.position, points[i].transform.position) < .1f) {
            i = i + 1;
            if(i >= points.Length) {
                i = 0;
            }
        }

        //checks distance to each point and then moves towards that point

        transform.position = Vector3.MoveTowards(transform.position, points[i].transform.position, speed * Time.deltaTime);
    }
}
