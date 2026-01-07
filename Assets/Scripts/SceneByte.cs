using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneByte : MonoBehaviour
{
    private string Scene2;
    //namn på scen du byter till
    public void OnTriggerEnter2D(Collider2D other)
    {
        //namn på objekt som triggar scenbyte
        if (other.tag == "Exit")
        {
            SceneManager.LoadScene(1);
        }
    }

}
