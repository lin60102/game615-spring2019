using UnityEngine;
using System.Collections;

public class ApplicationManager : MonoBehaviour {

    void Start()
    {
        Screen.SetResolution(1024, 768, false);
    }
    public void Quit () 
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
