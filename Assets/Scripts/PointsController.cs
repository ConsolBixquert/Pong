using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class PointsController : MonoBehaviour
{
    int pointsPlayer1;
    int pointsPlayer2;
    [SerializeField]
    TextMeshProUGUI text_P1;
    [SerializeField]
    TextMeshProUGUI text_P2;

    public BallController finish;
    public MenuController winnerP1Message;
    public MenuController winnerP2Message;

    // Start is called before the first frame update
    void Start()
    {
        text_P1.text = pointsPlayer1.ToString();
        text_P2.text = pointsPlayer2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text_P1.text = $"{pointsPlayer1}";
        text_P2.text = $"{pointsPlayer2}";
    }
    public void AddPointsPlayer1()
    {
        pointsPlayer1++;
        text_P1.text = pointsPlayer1.ToString();

        if (pointsPlayer1 == 5)
        {
            finish.Finish();
            winnerP1Message.WinnerP1Message();
            pointsPlayer1 = 0;
            pointsPlayer2 = 0;
        }
    }
    public void AddPointsPlayer2()
    {
        pointsPlayer2++;
        text_P2.text = pointsPlayer2.ToString();

        if (pointsPlayer2 == 5)
        {
            finish.Finish();
            winnerP2Message.WinnerP2Message();
            pointsPlayer1 = 0;
            pointsPlayer2 = 0;

        }
    }
}
