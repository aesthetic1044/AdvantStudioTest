using UnityEngine;
using UnityEngine.EventSystems;

public class InputHandler : MonoBehaviour
{
    private Player _player;

    private void Awake() => _player = GetComponent<Player>();
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            _player.ChangeGravity();
        }
    }
}
