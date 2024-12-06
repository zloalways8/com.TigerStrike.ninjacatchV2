using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private List<TextMeshProUGUI> _scores;

    [Inject] private readonly WinView _winView;
    [Inject] private readonly PlayerScore _playerScore;


    private void Awake()
    {
        _playerScore.ScoreUpdated += Handle;
        Handle(0);
    }

    private void Handle(int score)
    {
        foreach(var i in _scores)
        {
            i.text = $"{score}/{_winView.DesiredScore}";
        }
    }

    private void OnDestroy() => _playerScore.ScoreUpdated -= Handle;
}