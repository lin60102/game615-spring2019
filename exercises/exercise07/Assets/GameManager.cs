using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Image fadePanelImg;
    public Animator Anim_player;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fadeIn());
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator fadeIn()
    {
        //In this function, we will slowly lower the 'alpha' (transparency) value of the giant
        //image's color to achieve a 'fade in' effect (fading from black to clear).
        while (fadePanelImg.color.a > 0)
        {
            float newAlpha = fadePanelImg.color.a - 0.5f * Time.deltaTime;
            fadePanelImg.color = new Color(0, 0, 0, newAlpha);

            //This line will end the function for this round of Unity's update cycle (at time=n)
            yield return null;
            //This is where the Unity update cycle will enter at time=n+1
        }

        //Once we're done fading, we can set the fade panel to inactive. We do this to avoid
        //the panel 'catching' clicks. Sometimes an invisible panel can make it so our click
        //events aren't recognized as expected.
        fadePanelImg.gameObject.SetActive(false);
        Anim_player.SetBool("start", true);
        //Start the drop the cube scene

    }

}
