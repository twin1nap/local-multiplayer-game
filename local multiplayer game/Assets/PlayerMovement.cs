using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D player1;
    public Rigidbody2D player2;

    public float movespeed = 10f; // Beweegsnelheid van de spelers
    public float jumpforce = 7f;  // Jumpkracht van de spelers
    public bool isGroundedP1 = true; // Grounded voor player 1
    public bool isGroundedP2 = true; // Grounded voor player 2

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // player 1
        float HorizontalInputp1 = Input.GetAxis("Horizontal");
        player1.velocity = new Vector2(HorizontalInputp1 * movespeed, player1.velocity.y);
        if (Input.GetKeyDown(KeyCode.W) && isGroundedP1)
        {
            player1.velocity = new Vector2(player1.velocity.x, jumpforce);
            isGroundedP1 = false; // Player 1 is niet meer grounded na springen
        }

        // player 2
        float HorizontalInputp2 = Input.GetAxis("Horizontal2");
        player2.velocity = new Vector2(HorizontalInputp2 * movespeed, player2.velocity.y);
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGroundedP2)
        {
            player2.velocity = new Vector2(player2.velocity.x, jumpforce);
            isGroundedP2 = false; // Player 2 is niet meer grounded na springen
        }
    }

    // ground test
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            if (gameObject == player1.gameObject)
            {
                isGroundedP1 = true;
            }

            if (gameObject == player2.gameObject)
            {

                isGroundedP2 = true;
            }
        }
    }

    // Ground detection for Player 1
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            if (gameObject == player1.gameObject)
            {
                isGroundedP1 = false;

                if (gameObject == player2.gameObject)
                {
                    isGroundedP2 = false;
                }
            }
        }
    }
}