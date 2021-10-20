using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{

    public float speed;
    Rigidbody rigidbody;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
        //movement
        float horizontal2 = Input.GetAxis("Horizontal2");
        float vertical2 = Input.GetAxis("Vertical2");
        rigidbody.velocity = new Vector3(horizontal2 * speed, 0, vertical2 * speed);

    }
}
