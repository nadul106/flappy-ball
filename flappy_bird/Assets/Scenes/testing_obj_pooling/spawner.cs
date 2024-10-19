using UnityEngine;

public class spawner : MonoBehaviour
{
    /*BLUEPRINT:
        The spawner will spawn a pillar every few seconds off screen using a timer and the instantiate function. Every pillar will have a self contained
        script that will delete the pillar after another few seconds when it has moved off screen
    */

    [SerializeField] GameObject cube;
    [SerializeField] GameObject player;
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, 0, player.transform.position.z);
        if(Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(cube, new Vector3(transform.position.x + 10, transform.position.y + Random.Range(-25, 25), transform.position.z), Quaternion.identity);
        }
    }
}
