using UnityEngine;

public class Tutorial : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButton(0) || Input.touchCount > 0)
        {
            gameObject.SetActive(false);
        }
    }
}
