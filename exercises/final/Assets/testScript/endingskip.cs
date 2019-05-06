using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class endingskip : MonoBehaviour
{
    public VideoPlayer vPlayer;
    // Start is called before the first frame update
    void Start()
    {
        vPlayer = GetComponent<VideoPlayer>();
        //vPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, "endvideo.mp4");
        vPlayer.url = "https://lin60102.github.io/game615-spring2019/exercises/final/web/StreamingAssets/Produce.mp4";
        vPlayer.Play();
        vPlayer.loopPointReached += CheckOver;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void btn_skip()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
         #else
		Application.Quit();
         #endif

    }
    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        //print("Video Is Over");
        #if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
    }
}
