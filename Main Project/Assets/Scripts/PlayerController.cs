using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private float horizontalInpit;
    private float verticalInput;
    private float speed = 10.0f;

    private GameManager gameManager;

    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameActive == true) { 

            horizontalInpit = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
        }
}

    private void FixedUpdate()
    {
        if (gameManager.isGameActive == true)
        {
            playerRB.AddForce(new Vector3(horizontalInpit, 0.0f, verticalInput) * speed);
        }
        else
        {
            playerRB.velocity = Vector3.zero;
            transform.position = startPos;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Game Over Plane"))
        {
            gameManager.GameOver();
        }
        else if (collision.gameObject.CompareTag("Finish"))
        {
            gameManager.GameFinished();
        }
    }
}
