using System;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int Score {  get; private set; }

    public event Action<int> ScoreUpdated;

    public void Add(int score) => ScoreUpdated?.Invoke(Score += score);
}