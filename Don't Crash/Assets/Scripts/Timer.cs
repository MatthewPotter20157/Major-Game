using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Collections;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // create a timer for how long the game has been open
        float timeNow = Time.realtimeSinceStartup;
        timeText.text = "Time:" + timeNow;
    }
}
