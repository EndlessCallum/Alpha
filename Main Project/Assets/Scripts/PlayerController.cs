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

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInpit = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        playerRB.AddForce(new Vector3(horizontalInpit, 0.0f, verticalInput) * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Game Over Plane"))
        {
            gameManager.GameOver();
        }
    }
}
