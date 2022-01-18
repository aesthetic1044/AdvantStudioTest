using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlockMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
