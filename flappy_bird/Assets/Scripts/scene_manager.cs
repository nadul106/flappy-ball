using UnityEngine;
using UnityEngine.SceneManagement;
public class scene_manager : MonoBehaviour
{
    public void load_scene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    public void Quit(){
        Application.Quit();
        Debug.Log("Application Quit");
    }
}
