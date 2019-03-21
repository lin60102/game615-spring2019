using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menucontrol : MonoBehaviour
{
    public string diff;
    public GameObject mainmenu;
    public GameObject optionmenu;
    public GameObject btneasy;
    public GameObject btnnormal;
    public GameObject btndiff;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1024, 768, false);
        diff = "Easy";
        mainmenu = GameObject.Find("main");
        optionmenu = GameObject.Find("optionmenu");
        btneasy= GameObject.Find("easyText");
        btnnormal = GameObject.Find("normalText");
        btndiff = GameObject.Find("diffText");
    }

    // Update is called once per frame
    void Update()
    {
        if (diff == "Easy")
        {
            btneasy.GetComponent<Text>().color = Color.yellow;
            btnnormal.GetComponent<Text>().color = Color.black;
            btndiff.GetComponent<Text>().color = Color.black;
        }
        else if (diff == "Normal")
        {
            btneasy.GetComponent<Text>().color = Color.black;
            btnnormal.GetComponent<Text>().color = Color.yellow;
            btndiff.GetComponent<Text>().color = Color.black;
        }
        else if (diff == "Hard")
        {
            btneasy.GetComponent<Text>().color = Color.black;
            btnnormal.GetComponent<Text>().color = Color.black;
            btndiff.GetComponent<Text>().color = Color.yellow;
        }

    }
    public void onbtnstart()
    {
        PlayerPrefs.SetString("diff", diff);
        SceneManager.LoadScene("game");
    }
    public void onbtnopt()
    {
        mainmuoff();
        optmuon();
    }
    public void onbtnquit()
    {
        Application.OpenURL("about:blank");
    }
    public void onbtneasy()
    {
        diff = "Easy";
    }
    public void onbtnnor()
    {
        diff = "Normal";
    }
    public void onbtndiff()
    {
        diff = "Hard";
    }
    public void onbtnback()
    {
        optmuoff();
        mainmuon();
    }

    void optmuon()
    {
        optionmenu.GetComponent<CanvasGroup>().alpha = 1;
        optionmenu.GetComponent<CanvasGroup>().interactable = true;
        optionmenu.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
    void optmuoff()
    {

        optionmenu.GetComponent<CanvasGroup>().alpha = 0;
        optionmenu.GetComponent<CanvasGroup>().interactable = false;
        optionmenu.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    void mainmuon()
    {
        mainmenu.GetComponent<CanvasGroup>().alpha = 1;
        mainmenu.GetComponent<CanvasGroup>().interactable = true;
        mainmenu.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
    void mainmuoff()
    {

        mainmenu.GetComponent<CanvasGroup>().alpha = 0;
        mainmenu.GetComponent<CanvasGroup>().interactable = false;
        mainmenu.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
}
