using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public PointsController points;
    public MenuController message;
    public Vector3 resetPosition;
    public float ballspeed;
    Rigidbody rb_Ball;
    Vector3 directionBall;
    bool playing = false;
    bool endGame = false;

    // Start is called before the first frame update
    void Start()
    {
        rb_Ball = this.GetComponent<Rigidbody>();
        directionBall = new Vector3(1, 0, 1);
    }

    void Update()
    {
        if (!playing && Input.GetKeyDown(KeyCode.Space) && !endGame)
        {
            playing = true;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(playing == true)
        {
            rb_Ball.MovePosition(rb_Ball.position + (ballspeed * directionBall * Time.deltaTime));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {

            switch (collision.gameObject.tag)
            {
                case "Pared Superior":
                    directionBall = new(directionBall.x, 0, -1);
                    break;

                case "Pared Inferior":
                    directionBall = new(directionBall.x, 0, 1);
                    break;

                case "Player1":
                    directionBall = new(1, 0, directionBall.z);
                    break;

                case "Player2":
                    directionBall = new(-1, 0, directionBall.z);
                    break;

                case "Pared Izquierda":
                    rb_Ball.MovePosition(resetPosition);
                    directionBall = new Vector3(-1, 0, 1);
                    playing = false;
                    points.AddPointsPlayer2();
                    message.ActiveMessage();
                    break;

                case "Pared Derecha":
                    rb_Ball.MovePosition(resetPosition);
                    directionBall = new Vector3(1, 0, 1);
                    playing = false;
                    points.AddPointsPlayer1();
                    message.ActiveMessage();
                    break;
            }
        }
    }
    public void Finish()
    {
        endGame = true;
    }

    public void Starting()
    {
        endGame = false;
    }
}
