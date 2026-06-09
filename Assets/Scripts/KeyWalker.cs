using UnityEngine;

public class KeyWalker : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
