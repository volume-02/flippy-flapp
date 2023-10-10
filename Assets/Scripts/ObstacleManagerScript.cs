using UnityEngine;

public class ObstacleManagerScript : MonoBehaviour
{
    public GameObject obstaclePrefab;

    void Start()
    {
        InvokeRepeating("GenerateObstacle", 0, 2);
    }

    void GenerateObstacle()
    {
        Instantiate(obstaclePrefab, new Vector3(15, Random.Range(-3, 3), 0), Quaternion.identity);
    }
}
