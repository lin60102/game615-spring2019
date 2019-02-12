using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    private GameObject ironman;
    private GameObject superman;
    private GameObject start;
    private GameObject camera;
    //
    public float Speed = 8;
    public float rotateSpeed = 8;
    

    //
    
    // Start is called before the first frame update
    void Start()
    {
        superman = GameObject.Find("SuperMan");
        ironman = GameObject.Find("ironman");
        start = GameObject.Find("start");
        camera= GameObject.Find("Main Camera");
        
    }

    // Update is called once per frame
    void Update()
    {
        //move
        Vector3 forward = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        float inputValue = Mathf.Max(Mathf.Abs(forward.x), Mathf.Abs(forward.z));
        if (inputValue > 0)
        {
            Quaternion lookRot = Quaternion.LookRotation(forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, rotateSpeed * inputValue * Time.deltaTime);
            transform.Translate(Vector3.forward * inputValue * Speed * Time.deltaTime);
        }
        
    }
    public void onbtnsuperman()
    {
        Destroy(ironman);
        Destroy(start);
        camera.GetComponent<cameramove>().target = superman.transform;
        
        //float y = (camera.transform.localPosition.y) - 200f;
        //camera.transform.localPosition = new Vector3((camera.transform.localPosition.x),y , (camera.transform.localPosition.z));
    }
    public void onbtnironman()
    {
        Destroy(superman);
        Destroy(start);
        camera.GetComponent<cameramove>().target = ironman.transform;
        //float y = (camera.transform.localPosition.y) - 200f;
        //camera.transform.localPosition = new Vector3((camera.transform.localPosition.x), y, (camera.transform.localPosition.z));
    }
    

}
