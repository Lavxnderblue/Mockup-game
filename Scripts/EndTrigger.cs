using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter ()
    {
        //This will trigger the end credits after the last level
        gameManager.CompleteLevel();
    }
}
