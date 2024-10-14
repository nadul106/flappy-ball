using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class bird_movement : MonoBehaviour
{
    [SerializeField ] float move_speed = 6.0f;
    [SerializeField] float jump_speed = 15.0f;
    [SerializeField] float speed_cap = 5f;
    Rigidbody bird_body = null;
    void Start()
    {
        bird_body = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(bird_body.linearVelocity.magnitude<speed_cap)
        {
            bird_body.AddForce(Vector3.right*move_speed);
        }
        Debug.Log("Speed=" + bird_body.linearVelocity.magnitude);
    }

    public void jump()
    {
        Debug.Log("Jumped");
        bird_body.AddForce(Vector3.up * jump_speed, ForceMode.Impulse);
    }
}
