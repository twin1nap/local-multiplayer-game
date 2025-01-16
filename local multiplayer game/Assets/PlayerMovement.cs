using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D player1;
    public Rigidbody2D player2;

    public float movespeed = 10f;
    public float jumpforce = 7f;
    public bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //player 1
        float HorizontalInputp1 = Input.GetAxis("Horizontal");
        player1.velocity = new Vector2(HorizontalInputp1 * movespeed, player1.velocity.y);
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            player1.velocity = new Vector2(player1.velocity.x, jumpforce);
        }

        //player 2
        float HorizontalInputp2 = Input.GetAxis("Horizontal2");
        player2.velocity = new Vector2(HorizontalInputp2 * movespeed, player2.velocity.y);
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            player2.velocity = new Vector2(player2.velocity.x, jumpforce);
        }
    }
    //ground test
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // Ground detection for Player 1
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

}