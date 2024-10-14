using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class pillar_script : MonoBehaviour
{
    private pillar_part[] pillar_parts;
    [SerializeField] GameObject player_mesh;
    [SerializeField] GameObject scene_loader;
    private scene_manager manager;
    void Start()
    {
        manager = scene_loader.GetComponent<scene_manager>();
        pillar_parts = GetComponentsInChildren<pillar_part>();
    }

    void Update()
    {
        foreach(pillar_part part in pillar_parts)
        {
            if(part.collided == true)
            {
                 manager.load_scene("death_screen");
            }
        }
    }
}
