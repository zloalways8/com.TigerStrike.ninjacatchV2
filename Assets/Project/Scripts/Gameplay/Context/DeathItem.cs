using UnityEngine;
using Zenject;

public class DeathItem : Item
{
    [Inject] private readonly WinView _winView;
    [Inject] private readonly LoseView _loseView;

    protected override void TriggerEnter(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerScore playerScore))
        {
            if(playerScore.Score >= _winView.DesiredScore) _winView.Enable();
            else _loseView.Enable();

            Destroy(playerScore.gameObject);
            Destroy(gameObject);
        }
    }
}