using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menucontrol : MonoBehaviour
{
    public int diff = 1;
    public GameObject mainmenu;
    public GameObject optionmenu;
    public GameObject btneasy;
    public GameObject btnnormal;
    public GameObject btndiff;
    // Start is called before the first frame update
    void Start()
    {
        mainmenu = GameObject.Find("main");
        optionmenu = GameObject.Find("optionmenu");
        btneasy= GameObject.Find("easyText");
        btnnormal = GameObject.Find("normalText");
        btndiff = GameObject.Find("diffText");
    }

    // Update is called once per frame
    void Update()
    {
        if (diff == 1)
        {
            btneasy.GetComponent<Text>().color = Color.yellow;
            btnnormal.GetComponent<Text>().color = Color.black;
            btndiff.GetComponent<Text>().color = Color.black;
        }
        else if (diff == 2)
        {
            btneasy.GetComponent<Text>().color = Color.black;
            btnnormal.GetComponent<Text>().color = Color.yellow;
            btndiff.GetComponent<Text>().color = Color.black;
        }
        else if (diff == 3)
        {
            btneasy.GetComponent<Text>().color = Color.black;
            btnnormal.GetComponent<Text>().color = Color.black;
            btndiff.GetComponent<Text>().color = Color.yellow;
        }

    }
    public void onbtnstart()
    {
        PlayerPrefs.SetInt("diff", diff);
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
        diff = 1;
    }
    public void onbtnnor()
    {
        diff = 2;
    }
    public void onbtndiff()
    {
        diff = 3;
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
