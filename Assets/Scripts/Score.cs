using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;
    private int _score = 0;

    private void Start()
    {
        _scoreText.text = $"{_score}%";
    }

    public void UpdateScore(int score)
    {
        if (_score == 95)
        {
            _scoreText.text = $"Победа";
        }
        else
        {
            _score = _score + score;
            _scoreText.text = $"{_score}%";
        }
    }
}