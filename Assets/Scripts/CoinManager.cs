using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public GameManager gameManager;
    public Coin coin;

    void Start()
    {
        InvokeRepeating("GenerateCoin", 1, 2);
    }

    void GenerateCoin()
    {
        var c = Instantiate(coin, new Vector3(15, Random.Range(-3, 3), 0), Quaternion.identity);
        c.GetComponent<FieldObject>().gameManager = gameManager;
    }

    void Update()
    {
        if (gameManager.isGameOver)
        {
            CancelInvoke();
        }
    }
}
