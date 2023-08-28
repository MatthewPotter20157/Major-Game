using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BusStop : MonoBehaviour
{
    public TextMeshProUGUI gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.text = "";


    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        gameOver.text = "gameOver";
    }
}
