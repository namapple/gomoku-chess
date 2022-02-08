using UnityEngine;
using UnityEngine.UI;

public class FireBall : MonoBehaviour
{
    [SerializeField] private Vector2 startingVelocity;
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 3);
    }
    void Start()
    {
        rb.velocity = startingVelocity;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.TryGetComponent<Enemy>(out var enemy)) enemy.Die();
        Destroy(gameObject);
    }
}
