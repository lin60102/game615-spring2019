using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timecount : MonoBehaviour
{
    int time_int = 15;
    private GameObject time;
    // Start is called before the first frame update
    void Start()
    {
        time = GameObject.Find("Time/Timer");
        InvokeRepeating("timer", 1, 1);
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void timer() {
        time_int -= 1;
        time.GetComponent<TextMesh>().text = (time_int.ToString());
        if (time_int == 0)
        {
            CancelInvoke("timer");
            time.GetComponent<TextMesh>().text = (time_int.ToString());
            Debug.Log(time_int);
        }
    }
}
