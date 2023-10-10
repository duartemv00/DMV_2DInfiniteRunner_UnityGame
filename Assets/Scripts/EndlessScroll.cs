using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessScroll : MonoBehaviour
{
    public float scrollFactor = -1;
    public Vector3 gameVelocity;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = gameVelocity * scrollFactor;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider gameArea) {
        //transform.position += Vector3.right * (gameArea.bounds.size.x + GetComponent<BoxCollider>().size.x);
        transform.position += Vector3.right * gameArea.bounds.size.x;
    }

    public void ResetPosition() {
        transform.position = new Vector3(16,transform.position.y,transform.position.z);
        rb.velocity = gameVelocity * scrollFactor;
    }
}
