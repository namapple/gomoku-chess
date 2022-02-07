using UnityEngine;

public class BGScaler : MonoBehaviour
{
    private SpriteRenderer sr;
    private Camera cam;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        cam = Camera.main;
    }
    void Start()
    {
        float worldHeight = cam.orthographicSize * 2f;
        float worldWidth = worldHeight * Screen.width / Screen.height;

        float height = sr.bounds.size.y;
        float width = sr.bounds.size.x;

        Vector3 tempScale = transform.localScale;
        tempScale.x = worldWidth / width;
        tempScale.y = worldHeight / height;
        transform.localScale = tempScale;
    }
}
