using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int lives = 3;

    [Header("Jump Properties")]
    public Vector3 gravity;
    public Vector3 jumpSpeed;
    bool isGrounded = false;

    Rigidbody rb;
    // Start is called before the first frame update
    void Awake() {
        Physics.gravity = gravity;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump") && isGrounded){
            rb.velocity = jumpSpeed;
            isGrounded = false;
        }

        if (Input.GetButtonUp("Jump")) {
            StopJump();
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ground") {
            isGrounded = true;
        }
    }

    void StopJump() {
        if (rb.velocity.y > 0) {
            rb.velocity = Vector3.zero;
        }
    }
}
