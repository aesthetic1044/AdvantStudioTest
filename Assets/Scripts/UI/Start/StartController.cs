using System;
using UnityEngine;
using UnityEngine.UI;

public class StartController : MonoBehaviour
{
    [SerializeField] private Button _button;

    [SerializeField] private GameObject _startPanel;

    [SerializeField] private PauseController _pauseController;

    private void Start() => Time.timeScale = 0;
    private void OnEnable() => _button.onClick.AddListener(StartGame);
    private void OnDisable() => _button.onClick.RemoveListener(StartGame);

    private void StartGame()
    {
        Time.timeScale = 1;
        _startPanel.SetActive(false);
    }
}
