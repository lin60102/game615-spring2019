using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class namescript : MonoBehaviour
{
    public GameObject title;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1024, 768, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void btna()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "a";
    }
    public void btnb()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "b";
    }
    public void btnc()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "c";
    }
    public void btnd()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "d";
    }
    public void btne()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "e";
    }
    public void btnf()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "f";
    }
    public void btng()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "g";
    }
    public void btnh()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "h";
    }
    public void btni()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "i";
    }
    public void btnj()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "j";
    }
    public void btnk()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "k";
    }
    public void btnl()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "l";
    }
    public void btnm()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "m";
    }
    public void btnn()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "n";
    }
    public void btno()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "o";
    }
    public void btnp()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "p";
    }
    public void btnq()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "q";
    }
    public void btnr()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "r";
    }
    public void btns()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "s";
    }
    public void btnt()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "t";
    }
    public void btnu()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "u";
    }
    public void btnv()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "v";
    }
    public void btnw()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "w";
    }
    public void btnx()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "x";
    }
    public void btny()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "y";
    }
    public void btnz()
    {
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "z";
    }
    public void ok()
    {
        PlayerPrefs.SetString("heroname",title.GetComponent<Text>().text);
        SceneManager.LoadScene("maingame");
        PlayerPrefs.SetInt("speed", 3);
        PlayerPrefs.SetInt("dmg", 5);
        PlayerPrefs.SetInt("herohp", 20);
        
    }
    public void cancel()
    {
        title.GetComponent<Text>().text ="";

    }
}
