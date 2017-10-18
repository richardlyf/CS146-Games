using UnityEngine;

public class ProbMovement : MonoBehaviour {

    public Rigidbody rb;
    public float timer = 3f;

    public float sideWaysForce = 5f;
    float currentTime = 0f;
    bool goingForward = true;

	// Update is called once per frame
	void FixedUpdate () {
		if(currentTime < timer && goingForward)
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            currentTime += Time.deltaTime;
        }
        else if(currentTime > -timer && !goingForward)
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            currentTime -= Time.deltaTime;
        }
        else
        {
            goingForward = !goingForward;
        }
	}
}
