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
    public GameObject instructionmenu;
    public GameObject btneasy;
    public GameObject btnnormal;
    public GameObject btndiff;
    public GameObject name;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1024, 768, false);
        diff = "Easy";
        mainmenu = GameObject.Find("main");
        name= GameObject.Find("name");
        optionmenu = GameObject.Find("optionmenu");
        instructionmenu = GameObject.Find("instructionmenu");
        btneasy = GameObject.Find("easyText");
        btnnormal = GameObject.Find("normalText");
        btndiff = GameObject.Find("diffText");
    }

    // Update is called once per frame
    void Update()
    {
        if (diff == "Easy")
        {
            btneasy.GetComponent<Text>().color = Color.blue;
            btnnormal.GetComponent<Text>().color = Color.black;
            btndiff.GetComponent<Text>().color = Color.black;
        }
        else if (diff == "Normal")
        {
            btneasy.GetComponent<Text>().color = Color.black;
            btnnormal.GetComponent<Text>().color = Color.blue;
            btndiff.GetComponent<Text>().color = Color.black;
        }
        else if (diff == "Hard")
        {
            btneasy.GetComponent<Text>().color = Color.black;
            btnnormal.GetComponent<Text>().color = Color.black;
            btndiff.GetComponent<Text>().color = Color.blue;
        }

    }
    public void onbtnstart()
    {
        PlayerPrefs.SetString("name", name.GetComponent<InputField>().text);
        PlayerPrefs.SetString("diff", diff);
        SceneManager.LoadScene("story");
    }
    public void onbtnopt()
    {
        mainmuoff();
        optmuon();
    }
    public void onbtninstruction()
    {
        instructionmenu.GetComponent<CanvasGroup>().alpha = 1;
        instructionmenu.GetComponent<CanvasGroup>().interactable = true;
        instructionmenu.GetComponent<CanvasGroup>().blocksRaycasts = true;
        mainmuoff();
    }
    public void onbtninstructionok()
    {
        instructionmenu.GetComponent<CanvasGroup>().alpha = 0;
        instructionmenu.GetComponent<CanvasGroup>().interactable = false;
        instructionmenu.GetComponent<CanvasGroup>().blocksRaycasts = false;
        mainmuon();
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
