using UnityEngine;
using Zenject;

public class GameplayInstaller : MonoInstaller
{
    [SerializeField] private WinView _winView;
    [SerializeField] private LoseView _loseView;
    [SerializeField] private PlayerScore _playerScore;

    public override void InstallBindings()
    {
        Container.
            Bind<WinView>().
            FromInstance(_winView).
            AsSingle().
            NonLazy();

        Container.
            Bind<LoseView>().
            FromInstance(_loseView).
            AsSingle().
            NonLazy();

        Container.
            Bind<PlayerScore>().
            FromInstance(_playerScore).
            AsSingle().
            NonLazy();
    }
}