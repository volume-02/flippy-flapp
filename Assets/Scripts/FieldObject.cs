using UnityEngine;

public class FieldObject : MonoBehaviour
{
    public GameManager gameManager;
    public int speed = 5;
    public int offset = -14;

    public void Destroy()
    {
        Destroy(gameObject);
    }

    void FixedUpdate()
    {
        if (!gameManager.isGameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            if (transform.position.x < offset)
            {
                Destroy();
            }
        }
    }
}
