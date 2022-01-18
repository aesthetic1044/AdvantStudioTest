using System;
using UnityEngine;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    [SerializeField] private Button _pauseButton;
    [SerializeField] private Button _ContinueButton;
    
    [SerializeField] private GameObject _pausePanel;
    
    private bool _isGameRunning = true;
    
    public void OnPause()
    {
        if (_isGameRunning)
        {
            Time.timeScale = 0;
            _isGameRunning = false;
            _pausePanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            _isGameRunning = true;
            _pausePanel.SetActive(false);
        }
    }
    
    private void OnEnable()
    {
        _pauseButton.onClick.AddListener(OnPause);
        _ContinueButton.onClick.AddListener(ContinueGame);
    } 
    private void OnDisable()
    {
        _pauseButton.onClick.RemoveListener(OnPause);
        _ContinueButton.onClick.RemoveListener(ContinueGame);
    }

    private void ContinueGame()
    {
        OnPause();
    }
}
