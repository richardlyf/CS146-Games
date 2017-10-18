using UnityEngine;

public class DeactivateNoticeBoard : MonoBehaviour
{
    public GameObject notice;

    public void deactivate()
    {
        notice.SetActive(false);
    }

}
