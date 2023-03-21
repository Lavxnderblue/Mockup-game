using UnityEngine;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        //this will make players exit the game, using the debug to show a message it works because unity will not close the game when programming
        Debug.Log("QUIT");
        Application.Quit();
    }
}
