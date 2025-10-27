using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject pointsCounter;
    public GameObject textStart;
    public GameObject imageSpacebar;
    public GameObject winnerMenu;
    public GameObject text_P1Winner;
    public GameObject text_P2Winner;

    public BallController finish;
    public BallController starting;



    // Start is called before the first frame update
    void Start()
    {
        startMenu.SetActive(true);
        pointsCounter.SetActive(false);
        winnerMenu.SetActive(false);
        text_P1Winner.SetActive(false);
        text_P2Winner.SetActive(false);

        finish.Finish();
    }

    public void StartButton()
    {
        startMenu.SetActive(false);
        pointsCounter.SetActive(true);

        starting.Starting();
    }

    public void ActiveMessage()
    {
        textStart.SetActive(true);
        imageSpacebar.SetActive(true);
    }

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
        {
            textStart.SetActive(false);
            imageSpacebar.SetActive(false);
        }
    }

    public void WinnerP1Message()
    {
        winnerMenu.SetActive(true);
        text_P1Winner.SetActive(true);
    }

    public void WinnerP2Message()
    {
        winnerMenu.SetActive(true);
        text_P2Winner.SetActive(true);
    }

    public void RestartButton()
    {
        startMenu.SetActive(true);
        pointsCounter.SetActive(false);
        winnerMenu.SetActive(false);
        text_P1Winner.SetActive(false);
        text_P2Winner.SetActive(false);
    }
}
