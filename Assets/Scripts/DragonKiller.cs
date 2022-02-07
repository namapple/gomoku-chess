using UnityEngine;
using UnityEngine.SceneManagement;
public class DragonKiller : MonoBehaviour
{
    [SerializeField] private AudioClip clip;
    private float restartDelay = 1f;
    void Update()
    {
        if (transform.position.y > 6 || transform.position.y < -6)
        {
            Invoke(nameof(Restart), restartDelay);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Invoke(nameof(Restart), restartDelay);
        AudioManager.instance.PlaySound(clip);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
