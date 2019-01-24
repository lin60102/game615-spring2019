using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    int[] num;
    float force = 0;
    // Start is called before the first frame update
    void Start()
    {
  
        sum(2, 5);
        //Debug.Log(sum(2, 5) );
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            force = force + 0.2f;
            Debug.Log(force);
        }
       
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.AddForce(transform.forward * force);
        }
    }
    int sum(int a, int b)
    {
        int total = a + b;
        return total;
    }
}
