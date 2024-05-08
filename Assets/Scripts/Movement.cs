using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;

    [SerializeField] private float jumpforce = 5f;

    private bool jump;

    float speed = 7f;
    // Update is called once per frame


    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    void Update()
    {
       

        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, 0);

        transform.position = transform.position + movementDirection * speed * Time.deltaTime;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;

        }

    }

    private void FixedUpdate()
    {
        if(jump)
        {
            rb.AddForce(Vector3.up * jumpforce,ForceMode.Impulse);
            jump = false;
        }
    }
}
