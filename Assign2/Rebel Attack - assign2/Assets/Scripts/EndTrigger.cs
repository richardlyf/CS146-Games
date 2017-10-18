using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GamerManager gameManager;
    public GameObject BGMusic;
    public float FadeTime = 1f;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        while(BGMusic.GetComponent<AudioSource>().volume > 0)
        {
            BGMusic.GetComponent<AudioSource>().volume -= 0.9f * Time.deltaTime / FadeTime;
        }
    }

}
