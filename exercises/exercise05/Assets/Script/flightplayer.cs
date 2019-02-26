using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flightplayer : MonoBehaviour
{
    public float forwardSpeed = 25f;
    public float rollSpeed = 35f;
    public float pitchSpeed = 20f;
    public float pitchSpeedRate = 5f;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("added to :" + gameObject.name);
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movecamto = transform.position - transform.forward * 10.0f + transform.up * 5.0f;
        Camera.main.transform.position = movecamto;
        Camera.main.transform.LookAt(transform.position);
        forwardSpeed += -transform.forward.y * pitchSpeedRate * Time.deltaTime;
        forwardSpeed = Mathf.Clamp(forwardSpeed, 0, 30);
        if (forwardSpeed < 0.5f)
        {
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().useGravity = true;
        }
        else
        {
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<Rigidbody>().useGravity = false;
        }
        transform.Translate(transform.forward * forwardSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Input.GetAxis("Vertical") * rollSpeed * Time.deltaTime, Input.GetAxis("Horizontal") * pitchSpeed / 4 * Time.deltaTime, -Input.GetAxis("Horizontal") * pitchSpeed * Time.deltaTime, Space.Self);
        float terrainheightwhereweare = Terrain.activeTerrain.SampleHeight(transform.position);
        if(terrainheightwhereweare> transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, terrainheightwhereweare, transform.position.z);
        }
    }
}
