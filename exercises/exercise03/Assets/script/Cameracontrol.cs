using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontrol : MonoBehaviour
{
    public GameObject earth;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - earth.transform.position;
    }

    void LateUpdate()
    {
        transform.position = earth.transform.position + offset;
    }
}

