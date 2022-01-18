using UnityEngine;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
    public UnityAction<int> _OnScoreUpdated;

    private float _scoreAmount;
    
    private void Update()
    {
        _scoreAmount += Time.deltaTime;
        _OnScoreUpdated?.Invoke((int)_scoreAmount);
    }
}
