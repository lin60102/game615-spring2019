using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class openingskip : MonoBehaviour
{
    public VideoPlayer vPlayer;
    string url;
    // Start is called before the first frame update
    void Start()
    {
        vPlayer = GetComponent<VideoPlayer>();
        vPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, "produce.mp4");
        //vPlayer.url = "https://lin60102.000webhostapp.com/Produce.mp4";
        vPlayer.Play();
        vPlayer.loopPointReached += CheckOver;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void btn_skip()
    {
        SceneManager.LoadScene("stage1");

    }
    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        //print("Video Is Over");
        SceneManager.LoadScene("stage1");
    }
}
