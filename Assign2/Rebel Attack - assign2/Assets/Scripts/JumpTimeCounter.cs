using UnityEngine;
using UnityEngine.UI;

public class JumpTimeCounter : MonoBehaviour {

    public PlayerMovement movement;

    public Text timerText;
    float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        timer = movement.getJumpTimer();
        timerText.text = "Boost Timer\n    ";
        timerText.text += timer.ToString("0");
    }
}
