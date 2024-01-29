using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public int pointsToWin = 3;
    private int points = 0; 
    public Text victoryText;

    private void OnEnable()
    {
        FinishLine.PlayerCrossedFinishLine += OnPlayerCrossedFinishLine;
    }

    private void OnDisable()
    {
        FinishLine.PlayerCrossedFinishLine -= OnPlayerCrossedFinishLine;
    }

    private void OnPlayerCrossedFinishLine()
    {
        Debug.Log("pro");

        points += 1;

        Debug.Log("Points: " + points);

        if (points >= pointsToWin)
        {
            Debug.Log("victor royal");

            victoryText.text = "cool";
        }
    }
}