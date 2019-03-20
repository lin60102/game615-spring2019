using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private GameObject option;
    private GameObject textwindow;
    private GameObject question1;
    private GameObject textshow;
    private GameObject item;
    private GameObject chest1;
    private GameObject chest2;
    private GameObject chest3;
    private GameObject chest4;
    private GameObject chest5;
    private GameObject inputQ1;
    private GameObject questionimage;
    private GameObject questionexplain;
    public GameObject lantern;
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject door4;
    public GameObject door5;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public string choose;
    public string source;
    public Sprite lamp;
    public Sprite key1;
    public Sprite key2;
    public Sprite key3;
    public Sprite q2img;
    public Sprite q3img;
    public Sprite q4img;
    int key = 0;
    int diff;
    
    

    // Start is called before the first frame update
    void Start()
    {
        diff = PlayerPrefs.GetInt("diff");
        lantern = GameObject.Find("lantern");
        chest1 = GameObject.Find("chest1b");
        chest2 = GameObject.Find("chest2b");
        chest3 = GameObject.Find("chest3b");
        chest4 = GameObject.Find("chest4b");
        chest5 = GameObject.Find("chest5b");
        door1 = GameObject.Find("door1");
        door2 = GameObject.Find("door2");
        door3 = GameObject.Find("door3");
        door4 = GameObject.Find("door4");
        door5 = GameObject.Find("door5");
        option = GameObject.Find("option");
        textwindow= GameObject.Find("textwindow");
        textshow= GameObject.Find("Textshow");
        question1= GameObject.Find("Question1");
        item = GameObject.Find("items");
        image1 = GameObject.Find("light");
        image2 = GameObject.Find("key1");
        image3 = GameObject.Find("key2");
        image4 = GameObject.Find("key3");
        inputQ1= GameObject.Find("Input1");
        questionimage= GameObject.Find("questionimage");
        questionexplain = GameObject.Find("questionexplain");
        lantern.SetActive(false);

     }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnTriggerEnter(Collider other)
    {
       
        switch (other.gameObject.name)
        {
            case "chest1b":
                choose = "chest1";
                opton();
                Debug.Log("chest1b");
                break;
            case "chest2b":
                choose = "chest2";
                opton();
                Debug.Log("chest2b");
                break;
            case "chest3b":
                choose = "chest3";
                opton();
                Debug.Log("chest3b");
                break;
            case "chest4b":
                choose = "chest4";
                opton();
                Debug.Log("chest4b");
                break;
            case "chest5b":
                choose = "chest5";
                opton();
                Debug.Log("chest5b");
                break;
            case "door1":
                itemoff();
                source = "question1";
                questionon();
                Debug.Log("door1");
                break;
            case "door2":
                itemoff();
                source = "question2";
                questionon();
                Debug.Log("door2");
                break;
            case "door3":
                itemoff();
                source = "question3";
                questionon();
                Debug.Log("door3");
                break;
            case "door4":
                itemoff();
                source = "question4";
                questionon();
                Debug.Log("door4");
                break;
            case "door5":
                door5.SetActive(false); //test
                Debug.Log("door5");
                break;
            case "door6":
                Debug.Log("door6");
                break;
        }
        
    }
    public void onbtnyes()
    {
        switch (choose)
        {
            case "chest1":
                txton("You find a lantern",100);
                image1.GetComponent<Image>().sprite = lamp;
                lantern.SetActive(true);
                choose = "";
                chest1.SetActive(false);
                break;
            case "chest2":
                txton("You find 1st Key",100);
                image2.GetComponent<Image>().sprite = key1;
                choose = "";
                key++;
                chest2.SetActive(false);
                break;
            case "chest3":
                txton("You find 2nd Key",100);
                image3.GetComponent<Image>().sprite = key2;
                choose = "";
                key++;
                chest3.SetActive(false);
                break;
            case "chest4":
                txton("You find a Trump underwear :)",100);
                chest4.SetActive(false);
                break;
            case "chest5":
                txton("You find 3rd Key",100);
                image4.GetComponent<Image>().sprite = key3;
                choose = "";
                key++;
                chest5.SetActive(false);
                break;
        }   

        optoff();
    }
    public void onbtnno()
    {
        
        optoff();
    }
    public void lightonoff()
    {
        if(lantern.activeSelf == true)
        {
            lantern.SetActive(false);
        }
        else
        {
            lantern.SetActive(true);
        }

    }
    void opton()
    {
        option.GetComponent<CanvasGroup>().alpha = 1;
        option.GetComponent<CanvasGroup>().interactable = true;
        option.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
    void optoff()
    {
        
        option.GetComponent<CanvasGroup>().alpha = 0;
        option.GetComponent<CanvasGroup>().interactable = false;
        option.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    void txton(string txt,int fontsize)
    {
        textshow.GetComponent<Text>().text = txt;
        textshow.GetComponent<Text>().fontSize = fontsize;
        textwindow.GetComponent<CanvasGroup>().alpha = 1;
        textwindow.GetComponent<CanvasGroup>().interactable = true;
        textwindow.GetComponent<CanvasGroup>().blocksRaycasts = true;
        Invoke("txtoff", 1.0f);

    }
    void txtoff()
    {
        textwindow.GetComponent<CanvasGroup>().alpha = 0;
        textwindow.GetComponent<CanvasGroup>().interactable = false;
        textwindow.GetComponent<CanvasGroup>().blocksRaycasts = false;
        CancelInvoke("txtoff");
    }
    void itemoff()
    {
        
        item.GetComponent<CanvasGroup>().alpha = 0;
        item.GetComponent<CanvasGroup>().interactable = false;
        item.GetComponent<CanvasGroup>().blocksRaycasts = false;
        

    }
    void itemon()
    {
        item.GetComponent<CanvasGroup>().alpha = 1;
        item.GetComponent<CanvasGroup>().interactable = true;
        item.GetComponent<CanvasGroup>().blocksRaycasts = true;
        
    }
    void questionon()
    {
        switch (source)
        {
            case "question1":

                break;
            case "question2":
                questionexplain.GetComponent<Text>().text = "78963->852->7456852->789654123=?";
                questionimage.GetComponent<Image>().sprite = q2img;
                break;
            case "question3":
                questionexplain.GetComponent<Text>().text = "PRGB=?";
                questionimage.GetComponent<Image>().sprite = q3img;
                break;
            case "question4":
                questionexplain.GetComponent<Text>().text = "BACD=?";
                questionimage.GetComponent<Image>().sprite = q4img;
                break;


        }
        question1.GetComponent<CanvasGroup>().alpha = 1;
        question1.GetComponent<CanvasGroup>().interactable = true;
        question1.GetComponent<CanvasGroup>().blocksRaycasts = true;

    }
    void questionoff()
    {
        question1.GetComponent<CanvasGroup>().alpha = 0;
        question1.GetComponent<CanvasGroup>().interactable = false;
        question1.GetComponent<CanvasGroup>().blocksRaycasts = false;

    }


    public void onbtnchkQ1()
    {
        switch (source)
        {
            case "question1":
                if (inputQ1.GetComponent<InputField>().text == "3081")
                {
                    txton("'Krr... creaaaaak....'The door is open", 90);
                    door1.SetActive(false); //test
                    inputQ1.GetComponent<InputField>().text = "";
                    questionoff();
                    itemon();
                }
                else
                {
                    inputQ1.GetComponent<InputField>().text = "";
                    txton("No repsonse... might be another password?", 90);
                }
                break;
            case "question2":
                if (inputQ1.GetComponent<InputField>().text == "7142")
                {
                    txton("'Krr... creaaaaak....'The door is open", 90);
                    door2.SetActive(false); //test
                    inputQ1.GetComponent<InputField>().text = "";
                    questionoff();
                    itemon();
                }
                else
                {
                    inputQ1.GetComponent<InputField>().text = "";
                    txton("No repsonse... might be another password?", 90);
                }
                break;
            case "question3":
                if (inputQ1.GetComponent<InputField>().text == "3698")
                {
                    txton("'Krr... creaaaaak....'The door is open", 90);
                    door3.SetActive(false); //test
                    inputQ1.GetComponent<InputField>().text = "";
                    questionoff();
                    itemon();
                }
                else
                {
                    inputQ1.GetComponent<InputField>().text = "";
                    txton("No repsonse... might be another password?", 90);
                }
                break;
            case "question4":
                if (inputQ1.GetComponent<InputField>().text == "3152")
                {
                    txton("'Krr... creaaaaak....'The door is open", 90);
                    door4.SetActive(false); //test
                    inputQ1.GetComponent<InputField>().text = "";
                    questionoff();
                    itemon();
                }
                else
                {
                    inputQ1.GetComponent<InputField>().text = "";
                    txton("No repsonse... might be another password?", 90);
                }
                break;


        }
        
        
    }
}
