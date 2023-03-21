using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; // a reference to the playerMovement script

    void OnCollisionEnter (Collision collisionInfo)
    {
        // to check if the object the player collides with is tagged with Obstacle
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // Disable the player movements
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
