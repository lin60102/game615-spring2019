using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseballmove : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Renderer render = gameObject.GetComponent<Renderer>();
        Color randomcolor = new Color(Random.value, Random.value, Random.value);
        render.material.color = randomcolor;
    }

    // Update is called once per frame
    void Update()
    {
        
            transform.position += transform.forward * speed * Time.deltaTime;
       
    }
}
