using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballmachine : MonoBehaviour
{
    float speed= 5f;
    GameObject ball;
    GameObject ballmachine;
    bool shouldRotate = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldRotate)
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime,0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject baseball = Instantiate(ballmachine, transform.position, transform.rotation);
            Destroy(baseball, 20f);
                
                }
    }
}
