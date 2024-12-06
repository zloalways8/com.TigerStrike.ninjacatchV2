using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class Item : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody2D _rigidbody;

    private Vector2 _velocity;

    protected abstract void TriggerEnter(Collider2D collision);

    protected void Restart()
    {
        float x = Random.Range(-2, 2);
        float y = Random.Range(0f, 5f);
        transform.localPosition = new Vector3(x, y);

        _rigidbody.velocity = Vector2.down * _speed * Random.Range(0.75f, 1.25f);
    }

    private void Awake()
    {
        Pause.Paused += HandlePaused;
        Pause.Resumed += HandleResumed;

        _rigidbody = GetComponent<Rigidbody2D>();
        Restart();
    }

    private void HandlePaused()
    {
        _velocity = _rigidbody.velocity;
        _rigidbody.velocity = Vector2.zero;
    }
    private void HandleResumed() => _rigidbody.velocity = _velocity;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TriggerEnter(collision);

        if (collision.CompareTag("ItemDeathZone")) Restart();
    }

    private void OnDestroy()
    {
        Pause.Paused -= HandlePaused;
        Pause.Resumed -= HandleResumed;
    }
}