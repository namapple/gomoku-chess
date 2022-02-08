using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private AudioClip clip;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var pos = new Vector2(transform.position.x + 1, transform.position.y);
            Instantiate(projectilePrefab, pos, projectilePrefab.transform.rotation);
            AudioManager.instance.PlaySound(clip);
        }
    }
}
