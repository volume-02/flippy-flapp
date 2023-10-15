using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<Renderer>().bounds.size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * 5 * Time.deltaTime);
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = new Vector3(36, 0, 10);
        }
    }
}
