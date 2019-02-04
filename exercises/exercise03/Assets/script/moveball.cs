using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class moveball : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;
    private Rigidbody rb;
    private int count;
    bool check;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("point"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            other.transform.localPosition = new Vector3(Random.Range(-75.0f, 75.0f), (other.transform.localPosition.y), Random.Range(-75.0f, 75.0f));
            other.gameObject.SetActive(true);
        }
    }

    void SetCountText()
    {
        countText.text = "Your Score: " + count.ToString();
        if (count >= 10)
        {
            winText.text = "You Win!";
        }
    }

    
}
