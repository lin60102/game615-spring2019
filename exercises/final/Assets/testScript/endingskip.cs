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
