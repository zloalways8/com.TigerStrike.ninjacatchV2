using UnityEngine;
using Zenject;

public class Destroyable : MonoBehaviour
{
    [Inject] private readonly WinView _winView;
    [Inject] private readonly LoseView _loseView;

    private void Awake()
    {
        _winView.Win += Destroy;
        _loseView.Lose += Destroy;
    }
    private void Destroy() => Destroy(gameObject);
    private void OnDestroy()
    {
        _winView.Win -= Destroy;
        _loseView.Lose -= Destroy;
    }
}