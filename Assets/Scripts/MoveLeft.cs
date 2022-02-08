using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 4;
    private Enemy enemy;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.left, Space.World);
        if (transform.position.x < -15)
        {
            transform.position += new Vector3(30, 0, 0);
            ShowRandomSprite();
            if (enemy != null) enemy.Respawn();
        }
    }

    private void ShowRandomSprite()
    {
        // number of children inside the current parent gameObject 
        int childCount = transform.childCount;
        int index = Random.Range(0, childCount);
        for (int i = 0; i < childCount; i++)
        {
            // take and assign a child to a var
            Transform child = transform.GetChild(i);
            // child.gameObject: take the GameObject linked to child.
            // gameObject here refers to the object – not the class –
            // that is linked to the transform.
            child.gameObject.SetActive(index == i);
        }
    }
    // to randomize right after hit "Play", if not, it will run a turn, then
    // randomize
    private void OnEnable() => ShowRandomSprite();
}
