using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class window : MonoBehaviour
{
    private GameObject time;
    private GameObject grade;
    private Rect windowPositionMove;
    private Rect buttonPosition;
    private Rect textPosition;
    // Start is called before the first frame update
    void Start()
    {
        time = GameObject.Find("Time/Timer");
        grade = GameObject.Find("/Grade/grade");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time.GetComponent<TextMesh>().text == "0")
        {
            setWindowPosition();
            setButtonPosition();
            setTextPosition();
        }
    }
    private void setWindowPosition()
    {
        float windowWidth = 150f;
        float windowHeight = 150f;
        float windowLeft = Screen.width * 0.5f - windowWidth * 0.5f;
        float windowTop = Screen.height * 0.5f - windowHeight * 0.5f;
        windowPositionMove = new Rect(windowLeft, windowTop, windowWidth, windowHeight);

      
    }

    private void setButtonPosition()
    {
        float buttonWidth = 40f;
        float buttonHeight = 40f;
        float buttonLeft = windowPositionMove.width * 0.5f - buttonWidth * 0.5f;
        float buttonTop = windowPositionMove.height * 0.8f - buttonHeight * 0.5f;

        buttonPosition = new Rect(buttonLeft, buttonTop, buttonWidth, buttonHeight);
    }
    private void setTextPosition()
    {
        float textWidth = 50f;
        float textHeight = 50f;
        float textLeft = windowPositionMove.width * 0.5f - textWidth * 0.5f;
        float textTop = windowPositionMove.height * 0.4f - textHeight * 0.5f;

        textPosition = new Rect(textLeft, textTop, textWidth, textHeight);
    }

    private void OnGUI()
    {
       windowPositionMove = GUI.Window(1, windowPositionMove, windowEvent, "Your Grade");
    }

    private void windowEvent(int id)
    {
        GUIStyle textstyle = new GUIStyle();
        textstyle.fontSize = 50;
        GUI.Label(textPosition, grade.GetComponent<TextMesh>().text, textstyle);
        
        if (GUI.Button(buttonPosition, "quit"))
        {
            if (id == 1)
            {
                //#if UNITY_EDITOR
                //UnityEditor.EditorApplication.isPlaying = false;
                //#else
                Application.Quit();
                Debug.Log("OK!@@");
            }
        }
        GUI.DragWindow();

    }
}
