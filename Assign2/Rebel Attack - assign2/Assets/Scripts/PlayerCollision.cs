using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public GameObject crashEf;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            crashEf.SetActive(false);
            crashEf.SetActive(true);
            FindObjectOfType<GamerManager>().EndGame();
        }
    }

}
