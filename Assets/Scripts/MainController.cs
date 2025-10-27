using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class MainController : MonoBehaviour
{
    float axisPlayer1;
    float axisPlayer2;
    public GameObject player1;
    public GameObject player2;
    public GameObject ball;
    public float speed;


    //Physics
    Rigidbody rb_Player1;
    Rigidbody rb_Player2;
    Rigidbody rb_Ball;

    Vector3 directionBall;

    // Start is called before the first frame update
    void Start()
    {
        rb_Player1 = player1.GetComponent<Rigidbody>();
        rb_Player2 = player2.GetComponent<Rigidbody>();
        rb_Ball = ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        axisPlayer1 = Input.GetAxis("Player1"); //Si hay algún input pulsado.
        axisPlayer2 = Input.GetAxis("Player2");
    }

    //El fixed Update es para físicas.
    private void FixedUpdate()
    {
        rb_Player1.MovePosition(rb_Player1.position + (axisPlayer1 * speed * player1.transform.forward * Time.deltaTime));
        rb_Player2.MovePosition(rb_Player2.position + (axisPlayer2 * speed * player2.transform.forward * Time.deltaTime));
    }
}
