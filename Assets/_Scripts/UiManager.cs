using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    // UiManager

    public TextMeshProUGUI scoreCard;

    public static UiManager instance;

    [SerializeField] Canvas _gameOverMenu;

    [Header("Timer")]
    [SerializeField] Image TimerImage;
    [SerializeField] float PlayingTime = 30f;

    float TimerValue;

    public float FillTransaction;

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        // open For Timer
        UpdateTimer();
        TimerImage.fillAmount = FillTransaction;
    }

    // Open  /*  For TImer....
    //........................
    //........................
    void UpdateTimer()
    {
        {
            TimerValue -= Time.deltaTime;


            if (TimerValue > 0)
            {
                FillTransaction = TimerValue / PlayingTime;
            }
            else
            {

                TimerValue = PlayingTime;
            }

            if (TimerValue < 0.2)
            {
                OpenGameOver();
            }
            // Debug.Log(Mathf.RoundToInt(TimerValue));
        }
    }

    public void OpenGameOver()
    {
        _gameOverMenu.enabled = true;
    }
}
