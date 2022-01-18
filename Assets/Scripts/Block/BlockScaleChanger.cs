using UnityEngine;

public class BlockScaleChanger : MonoBehaviour
{
    [SerializeField] private float _minScale;
    [SerializeField] private float _maxScale;
    
    private void Start()
    {
        float newScale = Random.Range(_minScale, _maxScale);
        transform.localScale = new Vector3(newScale, transform.localScale.y);
    }
    
}
