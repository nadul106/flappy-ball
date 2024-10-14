using UnityEngine;

public class pillar_part : MonoBehaviour
{
    [HideInInspector]public bool collided = false;
    public void OnCollisionEnter()
    {
        Debug.LogWarning("You Died");
        collided = true;
    }

    public void OnCollsionExit()
    {
        collided = false;
    }
}
