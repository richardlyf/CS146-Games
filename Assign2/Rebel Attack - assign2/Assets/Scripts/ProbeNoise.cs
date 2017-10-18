using UnityEngine;

public class ProbeNoise : MonoBehaviour {

    public float distance = 20f;
	// Update is called once per frame
	void Update () {
        if(this.GetComponent<Rigidbody>().position.z -
            FindObjectOfType<PlayerMovement>().GetComponent<Rigidbody>().position.z < distance)
        {
            this.GetComponent<AudioSource>().enabled = true;
        }
	}
}
