using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManagerScript : MonoBehaviour
{
    public GameObject obstaclePrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateObstacle", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GenerateObstacle()
    {
        Instantiate(obstaclePrefab, new Vector3(15, Random.Range(-3, 3), 0), Quaternion.identity);
    }
}
