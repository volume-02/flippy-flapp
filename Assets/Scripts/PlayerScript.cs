using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    new Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < 4)
        {
            rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }

        if (transform.position.y <= -4)
        {
            transform.position = new Vector3(0, -4, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ti proigral");
    }
}
