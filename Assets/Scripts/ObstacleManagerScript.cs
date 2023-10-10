using UnityEngine;

public class ObstacleManagerScript : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject obstaclePrefab;

    void Start()
    {
        InvokeRepeating("GenerateObstacle", 0, 2);
    }

    void GenerateObstacle()
    {
        var obst = Instantiate(obstaclePrefab, new Vector3(15, Random.Range(-3, 3), 0), Quaternion.identity);
        obst.GetComponent<FieldObject>().gameManager = gameManager;
    }

    void Update()
    {
        if (gameManager.isGameOver)
        {
            CancelInvoke();
        }
    }
}
