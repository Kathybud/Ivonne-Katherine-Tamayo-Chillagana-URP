using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public Text timerTxt;
    public Button startTimerBtn;
    public Button stopTimerBtn;
    IEnumerator _timerCR;

    void Awake()
    {
        startTimerBtn.onClick.AddListener(StartTimerClick);
        stopTimerBtn.onClick.AddListener(StopTimerClick);
        ResetTimer();
    }

    #region button clicks
    void StartTimerClick()
    {
        _timerCR = StartTimer();
        StartCoroutine(_timerCR);
    }

    void StopTimerClick()
    {
        if (_timerCR != null)
        {
            StopCoroutine(_timerCR);
            _timerCR = null;
        }
        ResetTimer();
    }
    #endregion

    #region start/reset timer
    IEnumerator StartTimer(int timeRemaining = 10)
    {
        startTimerBtn.interactable = false;
        stopTimerBtn.interactable = true;
        for (int i = timeRemaining; i > 0; i--)
        {
            timerTxt.text = i.ToString("00");
            yield return new WaitForSeconds(1);
        }
        ResetTimer();
    }

    void ResetTimer()
    {
        startTimerBtn.interactable = true;
        stopTimerBtn.interactable = false;
        timerTxt.text = "00";
    }
    #endregion
}
