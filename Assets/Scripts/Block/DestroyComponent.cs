using System;
using UnityEngine;

public class DestroyComponent : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out BlockMover block))
        {
            Destroy(block.gameObject);
        }
    }
}
