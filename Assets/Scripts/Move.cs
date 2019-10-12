using UnityEngine;

public class Move : MonoBehaviour
{

    private float _delta = 2;
    private float _speed = 0.02f;
    private float _startX;
    private float _endX;

    void Start()
    {
        transform.position += new Vector3(-_delta / 2, 0, 0);
        _startX = transform.position.x;
        _endX = transform.position.x + _delta;
    }

    void Update()
    {
        transform.position += new Vector3(_speed, 0, 0);
        var x = transform.position.x;
        if ((x <= _startX && _speed < 0) || (x >= _endX && _speed > 0))
        {
            _speed = -_speed;
        }
    }
}
