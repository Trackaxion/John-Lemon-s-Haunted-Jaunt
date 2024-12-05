using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private int time;
    public GameEnding gameEnding;

    public TextMeshProUGUI timeText;

    void Start()
    {
        time = 120;
        timeText.text = time + " Seconds";
        StartCoroutine(TimeRoutine());
    }

    void Update()
    {
        if(time == -1)
        {
            gameEnding.CaughtPlayer();
            Destroy(this.gameObject);
        }
        if(gameEnding.m_IsPlayerAtExit == true)
        {
            Destroy(this.gameObject);
        }
    }

    IEnumerator TimeRoutine()
    {
        WaitForSeconds delay = new WaitForSeconds(1);
        while(true)
        {
            time -= 1;
            yield return delay;
            timeText.text =  time + " Seconds";
        }
    }
}
