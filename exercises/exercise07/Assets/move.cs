using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class move : MonoBehaviour
{
    public GameObject mariotxt;
    public GameObject eat;
    public GameObject see;
    public Animator Anim_player;
   

    // Start is called before the first frame update
    void Start()
    {
        
        mariotxt = GameObject.Find("mariotext");
        eat = GameObject.Find("eat");
        see = GameObject.Find("see");
        Anim_player = GetComponent<Animator>();
        mariotxt.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }
   
    IEnumerator OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        switch (other.gameObject.name)
        {
            case "see":
                mariotxt.SetActive(true);
                yield return new WaitForSeconds(0.5f);
                see.SetActive(false);
                mariotxt.SetActive(false);

                break;
            case "eat":
                Anim_player.SetBool("eat", true);
                eat.SetActive(false);
                break;

        }
    }
}
