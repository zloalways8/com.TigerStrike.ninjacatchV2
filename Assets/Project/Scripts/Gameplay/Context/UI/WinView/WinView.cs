using System;
using UnityEngine;

public class WinView : MonoBehaviour
{
    public event Action Win;
    public int DesiredScore => _desiredScore;

    [SerializeField] private GameObject _view;
    [SerializeField] private int _desiredScore;

    public void Enable()
    {
        _view.SetActive(true);
        Win?.Invoke();
    }
}