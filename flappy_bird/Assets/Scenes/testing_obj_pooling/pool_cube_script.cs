using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pool_cube_script : MonoBehaviour
{
    float target_time = 15f;
    void Update()
    {
        target_time -= Time.deltaTime;
        if(target_time < 0.0f)
        {
            Destroy(gameObject);
        }
    }
}
