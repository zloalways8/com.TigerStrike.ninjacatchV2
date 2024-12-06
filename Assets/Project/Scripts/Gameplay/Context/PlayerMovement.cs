using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody;

    private Vector2 _velocity;

    private void Awake()
    {
        Pause.Paused += HandlePaused;
        Pause.Resumed += HandleResumed;

        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void HandlePaused() => _rigidbody.velocity = Vector2.zero;
    private void HandleResumed() => _rigidbody.velocity = _velocity;

    public void MoveRight() => Move(Vector2.right);
    public void MoveLeft() => Move(Vector2.left);
    public void StopMove() => _rigidbody.velocity = Vector2.zero;

    private void Move(Vector2 direction) => _rigidbody.velocity = direction * _speed;

    private void OnDestroy()
    {
        Pause.Paused -= HandlePaused;
        Pause.Resumed -= HandleResumed;
    }
}