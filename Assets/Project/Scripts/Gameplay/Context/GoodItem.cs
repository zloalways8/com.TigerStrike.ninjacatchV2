using UnityEngine;
using Zenject;

public class GoodItem : Item
{
    [SerializeField] private int Coast;

    [Inject] private readonly WinView _winView;

    protected override void TriggerEnter(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerScore component))
        {
            component.Add(Coast);
            if(component.Score >= _winView.DesiredScore) _winView.Enable();
            Restart();
        }
    }
}