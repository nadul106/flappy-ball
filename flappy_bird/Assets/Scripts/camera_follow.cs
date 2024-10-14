using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class camera_follow : MonoBehaviour
{
    [SerializeField][Range(0.0f, 50.0f)]float camera_look_depth = 24.0f;
    [SerializeField] Transform bird_transform;
    [SerializeField] float cam_smooth_time;

    private Vector3 target;
    private Vector3 current;

    private Vector3 velocity = Vector3.zero;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (bird_transform != null)
        {   //transform.position = new Vector3(bird_transform.position.x, bird_transform.position.y, bird_transform.position.z - camera_look_depth);
            target = new Vector3(bird_transform.position.x, bird_transform.position.y, bird_transform.position.z - camera_look_depth);
            transform.position = Vector3.SmoothDamp(transform.position, target, ref velocity, cam_smooth_time);
        }
    }
}
