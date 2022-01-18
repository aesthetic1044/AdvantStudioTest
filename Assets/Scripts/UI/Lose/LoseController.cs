using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseController : MonoBehaviour
{
    [SerializeField] private Button _button;

    [SerializeField] private GameObject _lostPanel;

    public void ShowLostPanel()
    {
        _lostPanel.SetActive(true);
        Time.timeScale = 0;
    }

    private void OnEnable() => _button.onClick.AddListener(RestartGame);
    private void OnDisable() => _button.onClick.RemoveListener(RestartGame);

    private void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
