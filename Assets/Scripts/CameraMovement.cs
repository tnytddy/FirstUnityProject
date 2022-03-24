using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform target;
    public Vector3 camOffset;
    // Start is called before the first frame update
    void Start()
    {
        camOffset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = target.transform.position + camOffset;
        transform.position = newPos;
    }
}
