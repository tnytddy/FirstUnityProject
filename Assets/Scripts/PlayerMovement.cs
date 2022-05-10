using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   Rigidbody player;
   public float moveSpeed = 8.0f;
   public float rotSpeed = 90.0f;
   public bool touchingGround = true;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        //sets movement for forward and backward, as well as turning

        float translation = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        
        //sets jump movement and checks in player is in the air to prevent another jump

        if(Input.GetButtonDown("Jump") && touchingGround) {
            player.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
            touchingGround = false;
        }

    }

    //resets touhcingGround back to true to allow jump

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Moving Box") {
            touchingGround = true;
        }
    }
}
