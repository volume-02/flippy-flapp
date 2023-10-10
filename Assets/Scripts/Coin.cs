using UnityEngine;

public class Coin : MonoBehaviour
{
    FieldObject fieldObject;
    public int price = 100;
    void Start()
    {
        fieldObject = GetComponent<FieldObject>();
    }

    private void OnTriggerEnter(Collider other)
    {
        fieldObject.Destroy();
    }
}
