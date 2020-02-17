using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{

    public void Quit()
    {
        Debug.Log("Quit Game");


        Application.Quit();
    }


    public void RestartGameTwo()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene("SampleScene");
    }

}
