using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   Rigidbody player;
   public float moveSpeed = 8.0f;
   public float rotSpeed = 100.0f;
   public bool onGround = true;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        float translation = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        

        //player.velocity = new Vector3(Input.GetAxis("Horizontal") * 12f, player.velocity.y, Input.GetAxis("Vertical") * 12f);

        if(Input.GetButtonDown("Jump") && onGround) {
            player.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
            onGround = false;
        }

        //onGround = true;

    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Moving Box") {
            onGround = true;
        }
    }
}
