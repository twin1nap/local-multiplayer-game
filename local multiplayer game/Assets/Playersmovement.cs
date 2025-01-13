//using UnityEngine;

//public class TwoPlayerMovement : MonoBehaviour
//{
//    // Speler 1 (WASD)
//    public GameObject player1;
//    public float speed1 = 5f;

//    // Speler 2 (Pijltoetsen)
//    public GameObject player2;
//    public float speed2 = 5f;

//    private Rigidbody2D rb1;
//    private Rigidbody2D rb2;

//    void Start()
//    {
//        // Haal de Rigidbody2D componenten van de spelers op
//        rb1 = player1.GetComponent<Rigidbody2D>();
//        rb2 = player2.GetComponent<Rigidbody2D>();
//    }

//    void Update()
//    {
//        // Beweging voor Speler 1 (WASD)
//        float moveHorizontal1 = 0f;
//        float moveVertical1 = 0f;

//        if (Input.GetKey(KeyCode.A)) moveHorizontal1 = -1;  // Beweeg naar links
//        if (Input.GetKey(KeyCode.D)) moveHorizontal1 = 1;   // Beweeg naar rechts
//        if (Input.GetKey(KeyCode.W)) moveVertical1 = 1;     // Beweeg omhoog
//        if (Input.GetKey(KeyCode.S)) moveVertical1 = -1;    // Beweeg omlaag

//        Vector2 movement1 = new Vector2(moveHorizontal1, moveVertical1);
//        rb1.velocity = movement1 * speed1;

//        // Beweging voor Speler 2 (Pijltoetsen)
//        float moveHorizontal2 = 0f;
//        float moveVertical2 = 0f;

//        if (Input.GetKey(KeyCode.LeftArrow)) moveHorizontal2 = -1;  // Beweeg naar links
//        if (Input.GetKey(KeyCode.RightArrow)) moveHorizontal2 = 1;   // Beweeg naar rechts
//        if (Input.GetKey(KeyCode.UpArrow)) moveVertical2 = 1;        // Beweeg omhoog
//        if (Input.GetKey(KeyCode.DownArrow)) moveVertical2 = -1;     // Beweeg omlaag

//        Vector2 movement2 = new Vector2(moveHorizontal2, moveVertical2);
//        rb2.velocity = movement2 * speed2;
//    }
//}
