using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (!gameManager.isGameOver)
       // {
            transform.Translate(Vector3.left * 15 * Time.deltaTime);
            if (transform.position.x < startPos.x - repeatWidth)
            {
                transform.position = new Vector3(75, -5, -5);
            }
       // }
    }
}
