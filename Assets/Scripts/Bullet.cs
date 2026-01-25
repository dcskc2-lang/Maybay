using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed;

    void Update()
    {
        transform.position += Vector3.up * flySpeed * Time.deltaTime;

        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);

        if (viewPos.y > 1 || viewPos.y < 0 ||
            viewPos.x > 1 || viewPos.x < 0)
        {
            Destroy(gameObject);
        }
    }
}
