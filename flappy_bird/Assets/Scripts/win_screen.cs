using UnityEngine;

public class win_script : MonoBehaviour
{
    [SerializeField] GameObject scene_loader;
    private scene_manager manager;
    void Start()
    {
        manager= scene_loader.GetComponent<scene_manager>();
    }
    void OnCollisionEnter()
    {
        manager.load_scene("win_screen");
    }
}
