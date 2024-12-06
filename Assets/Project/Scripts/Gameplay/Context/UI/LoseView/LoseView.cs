using System;
using UnityEngine;

public class LoseView : MonoBehaviour
{
    public event Action Lose;

    [SerializeField] private GameObject _view;

    public void Enable()
    {
        _view.SetActive(true);
        Lose?.Invoke();
    }
}