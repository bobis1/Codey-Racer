using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountdown : MonoBehaviour
{
    public TextMeshProUGUI startCountdown;
    public TextMeshProUGUI lapTime;

    public float totalLapTime;
    public float totalCountdownTime;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        totalLapTime -= Time.deltaTime;
        totalCountdownTime -= Time.deltaTime;

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
        if(totalCountdownTime == 0)
        {
            Debug.Log("start");
        }
    }
}
