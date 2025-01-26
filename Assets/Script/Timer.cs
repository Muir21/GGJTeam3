using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float startTime = 60f;   //can be changed in editor, is in seconds
    public TextMeshProUGUI timerText;      //UI element that displays the time

    private float currentTime;     //current time
    private bool isCountingDown = true;     //to stop counter when it hits 0

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        UpdateTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (isCountingDown)
        {
            // Decrease the current time
            currentTime -= Time.deltaTime;

            // If the time reaches 0, stop the timer and execute the EndLevel function
            if (currentTime <= 0)
            {
                currentTime = 0;
                isCountingDown = false;
                EndLevel();
            }
            UpdateTimer();
        }
    }

    void UpdateTimer()
    {
        if (timerText != null)
        {
            int minutes = Mathf.FloorToInt(currentTime / 60);
            int seconds = Mathf.FloorToInt(currentTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    
    void EndLevel()
    {
        // Add level end things here or call a code in another script
    }

}
