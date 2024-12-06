using Zenject;

public class ProjectInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.
            Bind<SceneLoader>().
            FromNew().
            AsSingle().
            NonLazy();
    }
}