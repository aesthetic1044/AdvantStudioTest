using System;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreVisual : MonoBehaviour
{
    [SerializeField] private ScoreController _scoreController;

    private TextMeshProUGUI _text;

    private void Awake() => _text = GetComponent<TextMeshProUGUI>();
    private void OnEnable() => _scoreController._OnScoreUpdated += UpdateText;
    private void OnDisable() => _scoreController._OnScoreUpdated -= UpdateText;
    
    private void UpdateText(int score)
    {
        _text.text = score.ToString();
    }
}
