using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    private Rigidbody rb;
    [SerializeField] float speed = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    private void FixedUpdate()
    {
        PlayerMovement();
    }
    void PlayerMovement()
    {
        //
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 faceDir = new Vector3(hor, 0, ver);
        //
        Vector3 movementDir = new Vector3 (transform.position.x + speed * hor, transform.position.y,transform.position.z + speed * ver);
        rb.MovePosition(movementDir);

        if(faceDir != Vector3.zero)
        {
            transform.forward = faceDir;
        }

        if(faceDir != Vector3.zero)
        {
            //play animation
        }

    }

    void Animations()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 faceDir = new Vector3(hor, 0, ver);
        if (faceDir != Vector3.zero)
        {
            //play animation
        }


    }
}
