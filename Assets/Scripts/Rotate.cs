using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float _speed = 0.5f;

    void Update()
    {
        transform.eulerAngles += new Vector3(0, 0, _speed);
    }
}
