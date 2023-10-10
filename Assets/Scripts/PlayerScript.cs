using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameManager gameManager;
    new Rigidbody rigidbody;
    public TMPro.TMP_Text scoreText; 
    int score { get; set; }
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!gameManager.isGameOver) 
        {
            if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < 4)
            {
                rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse);
            }

            if (transform.position.y <= -4)
            {
                transform.position = new Vector3(0, -4, 0);
            }
        } else
        {
            rigidbody.isKinematic = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        hitCoin(other);
        hitObstacle(other);
        overflightObstacle(other);
        scoreText.text = score.ToString();
    }

    void hitCoin(Collider other)
    {
        Coin coin = other.GetComponent<Coin>();
        if (coin != null)
        {
            score += coin.price;
        }
    }

    void hitObstacle(Collider other)
    {
        ObstacleScript obstacle = other.transform.parent?.GetComponent<ObstacleScript>();
        if (obstacle != null)
        {
            gameManager.GameOver();
        }
    }

    void overflightObstacle(Collider other)
    {
        ObstacleScript obstacle = other.GetComponent<ObstacleScript>();
        if (obstacle != null)
        {
            score += obstacle.price;
        }
    }
}
