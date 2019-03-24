using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class animationcontrol : MonoBehaviour
{
    public GameObject storytext1;
    public Animator Anim_player;
    private GameObject story1;
    private GameObject story2;
    private GameObject story3;
    private GameObject story4;
    private GameObject story5;
    private GameObject story2anim;
    private GameObject story3anim;
    private GameObject story4anim;
    private GameObject story5anim;
    private GameObject name;
    // Start is called before the first frame update
    void Start()
    {
        name= GameObject.Find("name");
        name.GetComponent<Text>().text= PlayerPrefs.GetString("name");
        Screen.SetResolution(1024, 768, false);
        story1 = GameObject.Find("story1");
        story2 = GameObject.Find("story2");
        story2anim = GameObject.Find("story2Text");
        story3anim = GameObject.Find("story3Text");
        story4anim = GameObject.Find("story4Text");
        story5anim = GameObject.Find("story5Text");
        story3 = GameObject.Find("story3");
        story4 = GameObject.Find("story4");
        story5 = GameObject.Find("story5");
        Anim_player = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Anim_player.GetCurrentAnimatorStateInfo(0).IsName("over"))
        {

            story1.SetActive(false);
            story2.GetComponent<CanvasGroup>().alpha = 1;
            story2.GetComponent<CanvasGroup>().interactable = true;
            story2.GetComponent<CanvasGroup>().blocksRaycasts = true;
            story2anim.GetComponent<Animator>().SetBool("move", true);
        }
        if (Anim_player.GetCurrentAnimatorStateInfo(0).IsName("over2"))
        {

            story2.SetActive(false);
            story3.GetComponent<CanvasGroup>().alpha = 1;
            story3.GetComponent<CanvasGroup>().interactable = true;
            story3.GetComponent<CanvasGroup>().blocksRaycasts = true;
            story3anim.GetComponent<Animator>().SetBool("move", true);
        }
        if (Anim_player.GetCurrentAnimatorStateInfo(0).IsName("over3"))
        {

            story3.SetActive(false);
            story4.GetComponent<CanvasGroup>().alpha = 1;
            story4.GetComponent<CanvasGroup>().interactable = true;
            story4.GetComponent<CanvasGroup>().blocksRaycasts = true;
            story4anim.GetComponent<Animator>().SetBool("move", true);
        }
        if (Anim_player.GetCurrentAnimatorStateInfo(0).IsName("over4"))
        {

            story4.SetActive(false);
            story5.GetComponent<CanvasGroup>().alpha = 1;
            story5.GetComponent<CanvasGroup>().interactable = true;
            story5.GetComponent<CanvasGroup>().blocksRaycasts = true;
            story5anim.GetComponent<Animator>().SetBool("move", true);
        }
        if (Anim_player.GetCurrentAnimatorStateInfo(0).IsName("over5"))
        {
            
            SceneManager.LoadScene("game");
        }
    }
    public void onbtns1skip()
    {
        story1.SetActive(false);
        story2.GetComponent<CanvasGroup>().alpha = 1;
        story2.GetComponent<CanvasGroup>().interactable = true;
        story2.GetComponent<CanvasGroup>().blocksRaycasts = true;
        story2anim.GetComponent<Animator>().SetBool("move", true);
    }
    public void onbtns2skip()
    {
        story2.SetActive(false);
        story3.GetComponent<CanvasGroup>().alpha = 1;
        story3.GetComponent<CanvasGroup>().interactable = true;
        story3.GetComponent<CanvasGroup>().blocksRaycasts = true;
        story3anim.GetComponent<Animator>().SetBool("move", true);
    }
    public void onbtns3skip()
    {
        story3.SetActive(false);
        story4.GetComponent<CanvasGroup>().alpha = 1;
        story4.GetComponent<CanvasGroup>().interactable = true;
        story4.GetComponent<CanvasGroup>().blocksRaycasts = true;
        story4anim.GetComponent<Animator>().SetBool("move", true);
    }
    public void onbtns4skip()
    {
        story4.SetActive(false);
        story5.GetComponent<CanvasGroup>().alpha = 1;
        story5.GetComponent<CanvasGroup>().interactable = true;
        story5.GetComponent<CanvasGroup>().blocksRaycasts = true;
        story5anim.GetComponent<Animator>().SetBool("move", true);
    }
    public void onbtns5skip()
    {
       
        SceneManager.LoadScene("game");
    }

}
