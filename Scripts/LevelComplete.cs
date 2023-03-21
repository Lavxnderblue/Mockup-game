using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        //This will load in the next level when player finishes one
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
