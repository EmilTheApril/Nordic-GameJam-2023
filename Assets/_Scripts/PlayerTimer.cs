using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTimer : MonoBehaviour
{
    [SerializeField] private float timeLeft;

    public void SetTime(float time)
    {
        timeLeft = time;
    }

    public void SetGameManagerTime()
    {
        GameManager.instance.SetTime(timeLeft, gameObject);
    }
}
