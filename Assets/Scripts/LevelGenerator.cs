using System;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public Camera movingCamera;

    private GameObject[] _prefabs;
    private float _height;
    private GameObject _lastBlock;

    private Type[] _behaviors = { typeof(Move), typeof(Rotate) };

    void Awake()
    {
        _height = movingCamera.orthographicSize;
        _prefabs = Resources.LoadAll<GameObject>("BlockPrefabs");
    }

    void Update()
    {
        if (_lastBlock == null || _lastBlock.transform.position.y < movingCamera.transform.position.y + _height * 2)
        {
            var pos = _lastBlock == null ? Vector3.zero : new Vector3(0, _lastBlock.transform.position.y + _height, 0);
            _lastBlock = Instantiate(_prefabs.RandomItem(), pos, Quaternion.identity, transform);
            _lastBlock.AddComponent(_behaviors.RandomItem());
        }
        RemoveOffscreenBlocks();
    }

    private void RemoveOffscreenBlocks()
    {
        foreach (Transform child in transform)
        {
            if (movingCamera.transform.position.y - child.position.y > _height * 2)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
