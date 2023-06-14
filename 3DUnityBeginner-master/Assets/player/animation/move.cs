using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{/*
    // Start is called before the first frame updates
    public float v;
    public Rigidbody rb;     //subir des propriétés physiques(pesenteur,masse,colision...)
    private Vector3 d;*/
    public float moveSpeed = 5f;
    public float jumpForce = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        // Déplacement horizontal
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical) * moveSpeed;
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

        // Sauter
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        // Rotation
        if (Input.GetKey(KeyCode.B))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 100f);
        }
        else if (Input.GetKey(KeyCode.V))
        {
            transform.Rotate(-Vector3.up * Time.deltaTime * 100f);
        }
    }
}
