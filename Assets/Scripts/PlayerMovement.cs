using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movement.y += 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement.y -= 1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement.x -= 1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement.x += 1;
        }

        transform.position += movement * speed * Time.deltaTime;
    }
}