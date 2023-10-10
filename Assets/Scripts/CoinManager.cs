using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public Coin coin;

    void Start()
    {
        InvokeRepeating("GenerateCoin", 1, 2);
    }

    void GenerateCoin()
    {
        Instantiate(coin, new Vector3(15, Random.Range(-3, 3), 0), Quaternion.identity);
    }
}
