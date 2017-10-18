using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;

    float offset;

    void Start()
    {
        offset = player.position.z;
    }

	// Update is called once per frame
	void Update () {  
		scoreText.text = (player.position.z - offset).ToString("0");
    }
}
