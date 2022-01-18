using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField] private Transform _upPoint;
    [SerializeField] private Transform _downPoint;
    
    [SerializeField] private LoseController _loseController;
    
    private float _gravity = -9.8f;

    private Rigidbody2D _rigidbody2D;
    
    public void ChangeGravity() => _gravity = -_gravity;

    private void Awake() => _rigidbody2D = GetComponent<Rigidbody2D>();

    private void Update()
    {
        if (transform.position.y >= _upPoint.position.y)
        {
            _loseController.ShowLostPanel();
        }
        else if (transform.position.y <= _downPoint.position.y)
        {
            _loseController.ShowLostPanel();
        }
    }

    private void FixedUpdate() 
    {
        _rigidbody2D.velocity = new Vector2(0.0f, _gravity);
    }
}
