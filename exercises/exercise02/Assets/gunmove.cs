using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunmove : MonoBehaviour
{
    private GameObject gun;
    private GameObject bullet;
    private Rigidbody burb;
    private GameObject grade;
    private GameObject time;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        gun = GameObject.Find("Gun");
        bullet = GameObject.Find("bullet");
        grade = GameObject.Find("/Grade/grade");
        time = GameObject.Find("Time/Timer");
        burb = bullet.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //move gun

        if (Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKey(KeyCode.UpArrow))
        {
            gun.GetComponent<Transform>().transform.localPosition += new Vector3(0, 0.05f, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            gun.GetComponent<Transform>().transform.localPosition += new Vector3(0, -0.05f, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            gun.GetComponent<Transform>().transform.localPosition += new Vector3(-0.05f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            gun.GetComponent<Transform>().transform.localPosition += new Vector3(0.05f, 0, 0);
        }

        //shoot

        if (Input.GetKeyDown(KeyCode.Space))
        {
            reset();
            shoot();
        }
        //limitation
        if (gun.transform.localPosition.x < -8)
        {
            gun.transform.localPosition =new Vector3(-8, (gun.transform.localPosition.y), (gun.transform.localPosition.z));
        }
        if (gun.transform.localPosition.x > 8)
        {
            gun.transform.localPosition = new Vector3(8, (gun.transform.localPosition.y), (gun.transform.localPosition.z));
        }
        if (gun.transform.localPosition.y > 4)
        {
            gun.transform.localPosition = new Vector3((gun.transform.localPosition.x), 4, (gun.transform.localPosition.z));
        }
        if (gun.transform.localPosition.y < -3)
        {
            gun.transform.localPosition = new Vector3((gun.transform.localPosition.x),-3, (gun.transform.localPosition.z));
        }
        //Game end
        if (time.GetComponent<TextMesh>().text == "0")
        {
            Destroy(this.gameObject);
        }

    }

    void reset() {
        float step = 0.1f * Time.deltaTime;
        float bullet_y = (gun.transform.localPosition.y) + 2.3f;
        bullet.transform.localPosition = new Vector3((gun.transform.localPosition.x), bullet_y, (gun.transform.localPosition.z));
        

    }
    void shoot()
    {
        burb.AddForce(new Vector3(0, 0, 600));
       
    }
   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Target")
        {
            count++;
            grade.GetComponent<TextMesh>().text = (count.ToString());
        }
       // Debug.Log(other.gameObject.name);
    }
  

}
