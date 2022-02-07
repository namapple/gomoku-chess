using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Vector2 jumpForce;
    [SerializeField] private AudioClip clip;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rb.AddForce(jumpForce);
            AudioManager.instance.PlaySound(clip);
        }
    }
}
