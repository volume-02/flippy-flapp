using UnityEngine;

public class FieldObject : MonoBehaviour
{
    public int speed = 5;
    public int offset = -14;

    public void Destroy()
    {
        Destroy(gameObject);
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x < offset)
        {
            Destroy();
        }
    }
}
