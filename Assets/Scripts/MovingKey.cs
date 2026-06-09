using UnityEngine;

public class MovingKey : MonoBehaviour
{
    public float moveSpeed = 2f;

    public float height = 1f;

    private float startY;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            startY +
            Mathf.Sin(Time.time * moveSpeed) * height,
            transform.position.z
        );
    }
}