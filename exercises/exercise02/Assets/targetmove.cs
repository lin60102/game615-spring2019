using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetmove : MonoBehaviour
{
    private GameObject target;
    private GameObject time;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Target");
        time = GameObject.Find("Time/Timer");
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("random", 1.7f);
        //Game end
        if (time.GetComponent<TextMesh>().text == "0")
        {
            Destroy(this.gameObject);
        }
    }
    void random()
    {
        target.transform.localPosition = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(-4.0f, 3.0f), (target.transform.localPosition.z));
        CancelInvoke("random");

    }
    

}
