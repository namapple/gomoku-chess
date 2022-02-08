using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    private float heightVariance = 1f;
    private void Update()
    {
        transform.position += heightVariance * Mathf.Sin(Time.time)
        * Time.deltaTime * Vector3.up;
    }
}
