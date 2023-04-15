using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counterText;

    public void SetText(float time)
    {
        counterText.text = $"Time left \n{time.ToString("0")}";
    }

    public void SetText(string text)
    {
        counterText.text = text;
    }
}
