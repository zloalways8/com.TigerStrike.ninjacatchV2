using UnityEngine;

public class HideOnPauseView : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;

    private void Awake()
    {
        Pause.Paused += HandlePaused;
        Pause.Resumed += HandleResumed;
    }

    private void HandlePaused() => _renderer.enabled = false;
    private void HandleResumed() => _renderer.enabled = true;

    private void OnDestroy()
    {
        Pause.Paused -= HandlePaused;
        Pause.Resumed -= HandleResumed;
    }
}