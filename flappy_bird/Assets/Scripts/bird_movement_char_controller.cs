using UnityEngine;

public class bird_movement_char_controller : MonoBehaviour
{
    [SerializeField] float move_speed;
    [SerializeField] float jump_speed;
    CharacterController controller = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        controller.SimpleMove(Vector3.right*move_speed);
    }

    public void Jump()
    {
        Debug.Log("Jumped");
        controller.SimpleMove(Vector3.up*jump_speed);
    }
}
