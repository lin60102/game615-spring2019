using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static ArrayList monster1;
    public static ArrayList monster2;
    public Animator animatormon1, animatormon2;
    public static Vector3 vt;
    public Vector3 mon1vt, mon2vt;
    public  int mon1hp, mon2hp, herohpint, speed, dmg;
    public static bool heroturn=true;
    bool checkmonspos = true;

    public GameObject mon1, mon2, hero,monstername,monsterclass,monsterhp,attbtntext,movebtn, attbtn,attbox,hero_hp,endbtn,herospeed, winpanel;
    public GameObject nametxt,atttxt;
    public GameObject winp, losep;
    
    void Start()
    {
        
        

        speed = PlayerPrefs.GetInt("speed");
        dmg= PlayerPrefs.GetInt("dmg");
        
        herohpint=PlayerPrefs.GetInt("herohp");
        Screen.SetResolution(1024, 768, false);
        
    
        mon1hp = 10;
        mon2hp = 10;
        monster1 = new ArrayList() ;
        monster2 = new ArrayList();
       


        monster1.Add("Alex");
        monster1.Add("Undead soldier");
        monster1.Add(2);
        monster1.Add(3);
        
        monster2.Add("Kevin");
        monster2.Add("Undead soldier");
        monster2.Add(2);
        monster2.Add(3);
        if (rename.renamecheck)
        {
            monster1[0]="chaox";
            monster1[1]="Orc Wolfrider";
            monster1[2]=3;
            monster1[3]=4;
            mon1hp = 20;
        }
    }

    
    void Update()
    {
        nametxt.GetComponent<Text>().text = PlayerPrefs.GetString("heroname");
        
        atttxt.GetComponent<Text>().text = PlayerPrefs.GetInt("dmg").ToString();
        hero_hp.GetComponent<Text>().text = PlayerPrefs.GetInt("herohp").ToString();
        //Debug.Log("hp=" + PlayerPrefs.GetInt("herohp").ToString());
        herospeed.GetComponent<Text>().text = PlayerPrefs.GetInt("speed").ToString();
        if (!mon1 && !mon2)
        {
            if(rename.renamecheck){
                //finally win
                winp.GetComponent<CanvasGroup>().alpha = 1;
                winp.GetComponent<CanvasGroup>().interactable = true;
                winp.GetComponent<CanvasGroup>().blocksRaycasts = true;
                //Debug.Log("asdsaaaa614ads56f48943111365d14saaf8d41a6df");
            }else{
                //win stage1
                winpanel.GetComponent<CanvasGroup>().alpha = 1;
                winpanel.GetComponent<CanvasGroup>().interactable = true;
                winpanel.GetComponent<CanvasGroup>().blocksRaycasts = true;
            }
        }
        else if (PlayerPrefs.GetInt("herohp") <= 0)
        {
            //lose
            losep.GetComponent<CanvasGroup>().alpha = 1;
            losep.GetComponent<CanvasGroup>().interactable = true;
            losep.GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
        if (PlayerPrefs.GetInt("herohp") <= (PlayerPrefs.GetInt("herohp")*0.4f))
        {
            hero_hp.GetComponent<Text>().color = Color.red;
        }

        //Debug.Log("heroturn="+heroturn);
        //Debug.Log("canmove=" + ClickattPosition.canmove);
        herohpint = PlayerPrefs.GetInt("herohp");
        
        // if(ClickattPosition.nowPosition==)   
        if (checkmonspos)
        {
            monster1.Insert(0, MonsterPosition.monsterPosition[0]);
            monster2.Insert(0, MonsterPosition.monsterPosition[1]);
            monster1[0] = MonsterPosition.monsterPosition[0];
            monster2[0] = MonsterPosition.monsterPosition[1];
            //Debug.Log(mon1vt);
            checkmonspos = false;
        }
        
        
       
        

        if (Vector3.Distance(ClickattPosition.nowPosition, MonsterPosition.monsterPosition[0]) <=1.4 && Vector3.Distance(ClickattPosition.nowPosition, hero.transform.position) <= 1.4) {
            
            monstername.GetComponent<Text>().text = monster1[1].ToString();
            monsterclass.GetComponent<Text>().text = monster1[2].ToString();
            mon1hp = mon1hp - dmg;
            //Debug.Log("mon1hp=" + mon1hp);
            if (mon1hp <= 5) {
                monsterhp.GetComponent<Text>().color = Color.red;
                monsterhp.GetComponent<Text>().text = mon1hp.ToString();
                if (mon1hp <= 0)
                {
                    //mon1.SetActive(false);
                    Destroy(mon1);
                    monsterhp.GetComponent<Text>().text = "";
                    monstername.GetComponent<Text>().text = "";
                    monsterclass.GetComponent<Text>().text = "";
                }
            } else { monsterhp.GetComponent<Text>().text = mon1hp.ToString(); }
            ClickattPosition.nowPosition = new Vector3(1000, 1000, 1000);
            //heroturn = false;
        }
        
        if (Vector3.Distance(ClickattPosition.nowPosition, MonsterPosition.monsterPosition[1]) <= 1.4 && Vector3.Distance(ClickattPosition.nowPosition, hero.transform.position) <= 1.4)
        {
            
            monstername.GetComponent<Text>().text = monster2[1].ToString();
            monsterclass.GetComponent<Text>().text = monster2[2].ToString();
            mon2hp = mon2hp - dmg;
           // Debug.Log("mon2hp=" + mon2hp);
            if (mon2hp <= 5)
            {
                monsterhp.GetComponent<Text>().color = Color.red;
                monsterhp.GetComponent<Text>().text = mon2hp.ToString();
                if (mon2hp <= 0)
                {
                    //mon1.SetActive(false);
                    Destroy(mon2);
                    monsterhp.GetComponent<Text>().text = "";
                    monstername.GetComponent<Text>().text = "";
                    monsterclass.GetComponent<Text>().text = "";
                }

            }else { monsterhp.GetComponent<Text>().text = mon2hp.ToString(); }
            ClickattPosition.nowPosition = new Vector3(100, 100, 100);
            //heroturn = false;
        }

        if (mon1)
        {
            if (mon1.transform.position != MonsterPosition.monsterPosition[0] && mon1.transform.position != MonsterPosition.monsterPosition[1])
            {
                checkmon1pos();

            }
           

        }
        else { MonsterPosition.monsterPosition[0] = new Vector3(9, 9, 9); }
        if (mon2)
        {
            if (mon2.transform.position != MonsterPosition.monsterPosition[0] && mon2.transform.position != MonsterPosition.monsterPosition[1])
            {
                checkmon2pos();
            }
           
        }
        else { MonsterPosition.monsterPosition[1] = new Vector3(90, 90, 90);  }
        
        //-------------
        if (mon1)
        {
            if (mon1.transform.position.x > 4) { mon1.transform.position = new Vector3(4, mon1.transform.position.y, mon1.transform.position.z); }
            if (mon1.transform.position.x < -4) { mon1.transform.position = new Vector3(-4, mon1.transform.position.y, mon1.transform.position.z); }
            if (mon1.transform.position.z > 4) { mon1.transform.position = new Vector3(mon1.transform.position.x, mon1.transform.position.y, 4); }
            if (mon1.transform.position.z < -4) { mon1.transform.position = new Vector3(mon1.transform.position.x, mon1.transform.position.y, -4); }
        }
        if (mon2)
        {
            if (mon2.transform.position.x > 4) { mon2.transform.position = new Vector3(4, mon2.transform.position.y, mon2.transform.position.z); }
            if (mon2.transform.position.x < -4) { mon2.transform.position = new Vector3(-4, mon2.transform.position.y, mon1.transform.position.z); }
            if (mon2.transform.position.z > 4) { mon2.transform.position = new Vector3(mon2.transform.position.x, mon2.transform.position.y, 4); }
            if (mon2.transform.position.z < -4) { mon2.transform.position = new Vector3(mon2.transform.position.x, mon2.transform.position.y, -4); }
        }
       
        
        //------------------------------
        //Debug.Log(MonsterPosition.monsterPosition.Count);
    }
    void checkmon1pos()
    {
       
     MonsterPosition.monsterPosition[0] = mon1.transform.position;
      
    }
    void checkmon2pos()
    { 
        MonsterPosition.monsterPosition[1] = mon2.transform.position;    
    }
    public IEnumerator monstermove()
    {
        Vector3 dest1, dest2;

        if (mon1) { dest1 = new Vector3(mon1.transform.position.x + (int)Random.Range(-2.0F, 2.0F), mon1.transform.position.y, mon1.transform.position.z + (int)Random.Range(-2.0F, 2.0F)); }
        else { dest1 = new Vector3(15, 15, 15); }
        if (mon2) { dest2 = new Vector3(mon2.transform.position.x + (int)Random.Range(-2.0F, 2.0F), mon2.transform.position.y, mon2.transform.position.z + (int)Random.Range(-2.0F, 2.0F)); }
        else { dest2 = new Vector3(105, 105, 105); }
        if (dest1.x > 4) { dest1 = new Vector3(4, dest1.y, dest1.z); }
        if (dest1.x < -4) { dest1 = new Vector3(-4, dest1.y, dest1.z); }
        if (dest1.z > 4) { dest1 = new Vector3(dest1.x, dest1.y, 4); }
        if (dest1.z < -4) { dest1 = new Vector3(dest1.x, dest1.y, -4); }
        if (dest2.x > 4) { dest2 = new Vector3(4, dest2.y, dest2.z); }
        if (dest2.x < -4) { dest2 = new Vector3(-4, dest2.y, dest2.z); }
        if (dest2.z > 4) { dest2= new Vector3(dest2.x, dest2.y, 4); }
        if (dest2.z < -4) { dest2 = new Vector3(dest2.x, dest2.y, -4); }
       // Debug.Log(dest1);
       // Debug.Log(dest2);

        if (dest1!= dest2 &&  dest1!= hero.GetComponent<Transform>().position && dest2 != hero.GetComponent<Transform>().position)
        {
            Path.camera = true;
            
            
            if (mon1) {
                animatormon2.SetBool("run", true);
                if (dest1.x > mon1.transform.position.x)
                {
                    for (float i = mon1.transform.position.x; i <= dest1.x; i = i + 1.0f)
                    {
                        mon1.transform.position = new Vector3(i, mon1.transform.position.y, mon1.transform.position.z);
                        yield return new WaitForSeconds(0.5f);
                        if (dest1.z > mon1.transform.position.z)
                        {
                            for (float j = mon1.transform.position.z; j <= dest1.z; j = j + 1.0f)
                            {
                                mon1.transform.position = new Vector3(mon1.transform.position.x, mon1.transform.position.y, j);
                                yield return new WaitForSeconds(0.5f);
                            }


                        }
                        else
                        {
                            for (float j = mon1.transform.position.z; j >= dest1.z; j = j - 1.0f)
                            {
                                mon1.transform.position = new Vector3(mon1.transform.position.x, mon1.transform.position.y, j);
                                yield return new WaitForSeconds(0.5f);
                            }
                        }
                    }


                }
                else
                {
                    for (float i = mon1.transform.position.x; i >= dest1.x; i = i - 1.0f)
                    {
                        mon1.transform.position = new Vector3(i, mon1.transform.position.y, mon1.transform.position.z);
                        yield return new WaitForSeconds(0.5f);
                        if (dest1.z > mon1.transform.position.z)
                        {
                            for (float j = mon1.transform.position.z; j <= dest1.z; j = j + 1.0f)
                            {
                                mon1.transform.position = new Vector3(mon1.transform.position.x, mon1.transform.position.y, j);
                                yield return new WaitForSeconds(0.5f);
                            }


                        }
                        else
                        {
                            for (float j = mon1.transform.position.z; j >= dest1.z; j = j - 1.0f)
                            {
                                mon1.transform.position = new Vector3(mon1.transform.position.x, mon1.transform.position.y, j);
                                yield return new WaitForSeconds(0.5f);
                            }
                        }
                    }
                }
                animatormon2.SetBool("run", false);
                mon1.transform.LookAt(hero.transform.position);
            }
            if (mon2)
            {
                animatormon1.SetBool("run", true);
                if (dest2.x > mon2.transform.position.x)
                {
                    for (float i = mon2.transform.position.x; i <= dest2.x; i = i + 1.0f)
                    {
                        mon2.transform.position = new Vector3(i, mon2.transform.position.y, mon2.transform.position.z);
                        yield return new WaitForSeconds(0.5f);
                        if (dest2.z > mon2.transform.position.z)
                        {
                            for (float j = mon2.transform.position.z; j <= dest2.z; j = j + 1.0f)
                            {
                                mon2.transform.position = new Vector3(mon2.transform.position.x, mon2.transform.position.y, j);
                                yield return new WaitForSeconds(0.5f);
                            }


                        }
                        else
                        {
                            for (float j = mon2.transform.position.z; j >= dest2.z; j = j - 1.0f)
                            {
                                mon2.transform.position = new Vector3(mon2.transform.position.x, mon2.transform.position.y, j);
                                yield return new WaitForSeconds(0.5f);
                            }
                        }
                    }


                }
                else
                {
                    for (float i = mon2.transform.position.x; i >= dest2.x; i = i - 1.0f)
                    {
                        mon2.transform.position = new Vector3(i, mon2.transform.position.y, mon2.transform.position.z);
                        yield return new WaitForSeconds(0.5f);
                        if (dest2.z > mon2.transform.position.z)
                        {
                            for (float j = mon2.transform.position.z; j <= dest2.z; j = j + 1.0f)
                            {
                                mon2.transform.position = new Vector3(mon2.transform.position.x, mon2.transform.position.y, j);
                                yield return new WaitForSeconds(0.5f);
                            }


                        }
                        else
                        {
                            for (float j = mon2.transform.position.z; j >= dest2.z; j = j - 1.0f)
                            {
                                mon2.transform.position = new Vector3(mon2.transform.position.x, mon2.transform.position.y, j);
                                yield return new WaitForSeconds(0.5f);
                            }
                        }
                    }
                }
                animatormon1.SetBool("run", false);
                mon2.transform.LookAt(hero.transform.position);
            }
           
            
            
            
           
            Path.camera = false;
            //CancelInvoke("monstermove");
            

        }
        else
        {
            StartCoroutine("monstermove");
            //Invoke("monstermove", 0.1f);
        }
        //mon1 move
        

    }
    IEnumerator monsteratt()
    {
        if (mon2)
        {
            if (Vector3.Distance(hero.transform.position, mon2.transform.position) <= 1.2)
            {
                mon2.transform.LookAt(hero.transform.position);
                animatormon1.SetBool("att", true);
                PlayerPrefs.SetInt("herohp", PlayerPrefs.GetInt("herohp") - 3);
                yield return new WaitForSeconds(1.5f);
                animatormon1.SetBool("att", false);
            }
        }
        if(mon1){
            if (Vector3.Distance(hero.transform.position, mon1.transform.position) <= 1.2)
            {
                mon1.transform.LookAt(hero.transform.position);
                animatormon2.SetBool("att", true);
                PlayerPrefs.SetInt("herohp", PlayerPrefs.GetInt("herohp") - 3);
                yield return new WaitForSeconds(1.5f);
                animatormon2.SetBool("att", false);
            }
        }
        yield return new WaitForSeconds(3.0f);
        movebtn.SetActive(true); 
        attbtn.SetActive(true); 
        endbtn.SetActive(true); 

    }
    public void btnendturn()
    {
        if (movebtn) { movebtn.SetActive(false); }
        if (attbtn) { attbtn.SetActive(false); }
        if (endbtn) { endbtn.SetActive(false); }

        //monstermove();
        StartCoroutine("monstermove");
        StartCoroutine("monsteratt");
        
    }
    public void btnspup()
    {
        PlayerPrefs.SetInt("speed", PlayerPrefs.GetInt("speed")+1);
        PlayerPrefs.SetInt("herohp", 20);
        //next scene
        SceneManager.LoadScene("stage2");
    }
    public void btndmgup()
    {
        PlayerPrefs.SetInt("dmg", PlayerPrefs.GetInt("dmg") + 3);
        //Debug.Log("dmg=" + PlayerPrefs.GetInt("dmg").ToString());
        PlayerPrefs.SetInt("herohp", 20);
        //next scene
        SceneManager.LoadScene("stage2");
    }
    public void btnhpup()
    {
        PlayerPrefs.SetInt("herohp", 23);
        //next scene
        SceneManager.LoadScene("stage2");
    }



}
