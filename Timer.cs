using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public int minutes = 4;
    private float seconds = 0f;

    public TextMeshProUGUI textTimer;

    void Update()
    {
        if(seconds > 59) 
        {
            
            if(minutes > 0) 
            {
                minutes--;
            }

            if(minutes == 0) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            
            seconds = 0f;
        } else {
            seconds += Time.deltaTime;
        }

        textTimer.text = minutes.ToString() + ':' + Mathf.RoundToInt(seconds).ToString();
    }
}

