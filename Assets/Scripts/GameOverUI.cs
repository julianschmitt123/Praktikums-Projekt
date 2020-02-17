using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    
    public void Quit()
    {
        Debug.Log("Quit Game");


        Application.Quit();
    }


    public class RestartGame : MonoBehaviour
    {
        public void Restart()
        {
            Debug.Log("Restart");
            SceneManager.LoadScene(SampleScene);
        }


    }
}
