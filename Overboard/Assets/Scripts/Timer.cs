using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text Text;
    public float timeLeft;

    [System.Obsolete]
    void Update()
    {
        timeLeft -= Time.deltaTime;
        Text.text = timeLeft.ToString("F2");
        if (timeLeft < 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
