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
        Screen.SetResolution(1024, 768, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void btna()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "a";
    }
    public void btnb()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "b";
    }
    public void btnc()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "c";
    }
    public void btnd()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "d";
    }
    public void btne()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "e";
    }
    public void btnf()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "f";
    }
    public void btng()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "g";
    }
    public void btnh()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "h";
    }
    public void btni()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "i";
    }
    public void btnj()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "j";
    }
    public void btnk()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "k";
    }
    public void btnl()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "l";
    }
    public void btnm()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "m";
    }
    public void btnn()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "n";
    }
    public void btno()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "o";
    }
    public void btnp()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "p";
    }
    public void btnq()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "q";
    }
    public void btnr()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "r";
    }
    public void btns()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "s";
    }
    public void btnt()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "t";
    }
    public void btnu()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "u";
    }
    public void btnv()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "v";
    }
    public void btnw()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "w";
    }
    public void btnx()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "x";
    }
    public void btny()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "y";
    }
    public void btnz()
    {
        clean();
        title.GetComponent<Text>().text = title.GetComponent<Text>().text + "z";
    }
    public void ok()
    {
        PlayerPrefs.SetString("heroname",title.GetComponent<Text>().text);
        SceneManager.LoadScene("opening");
        PlayerPrefs.SetInt("speed", 3);
        PlayerPrefs.SetInt("dmg", 5);
        PlayerPrefs.SetInt("herohp", 20);
        
    }
    public void cancel()
    {
        title.GetComponent<Text>().text ="";

    }
    void clean()
    {
        if(title.GetComponent<Text>().text == "Korean Fish") { title.GetComponent<Text>().text = ""; }
    }
}
