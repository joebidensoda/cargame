using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    
    public delegate void OnPlayerCrossedFinishLine();
    public static event OnPlayerCrossedFinishLine PlayerCrossedFinishLine;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("car1"))
        {
            PlayerCrossedFinishLine?.Invoke();
        }
        if (collision.CompareTag("car2"))
        {
            PlayerCrossedFinishLine?.Invoke();
        }
    }
}