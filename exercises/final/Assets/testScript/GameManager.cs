using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static ArrayList monster1;
    public static ArrayList monster2;
    public static Vector3 vt;
    public Vector3 mon1vt, mon2vt;
    public  int mon1hp, mon2hp;
    public static bool heroturn=true;
    bool checkmonspos = true;

    public GameObject mon1, mon2, hero,monstername,monsterclass,monsterhp,attbtntext,movebtn, attbtn,attbox;

    // Start is called before the first frame update
    void Start()
    {
        mon1vt= new Vector3(0, 0, 0);
        mon2vt = new Vector3(0, 0, 0);
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
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("heroturn="+heroturn);
        Debug.Log("canmove=" + ClickattPosition.canmove);
    
        // if(ClickattPosition.nowPosition==)   
        if (checkmonspos)
        {
            monster1.Insert(0, MonsterPosition.monsterPosition[0]);
            monster2.Insert(0, MonsterPosition.monsterPosition[1]);
            monster1[0] = MonsterPosition.monsterPosition[0];
            monster2[0] = MonsterPosition.monsterPosition[1];
            Debug.Log(mon1vt);
            checkmonspos = false;
        }
        mon1vt = MonsterPosition.monsterPosition[0];
        mon2vt = MonsterPosition.monsterPosition[1];
        
       
        

        if (Vector3.Distance(ClickattPosition.nowPosition, mon1vt)<=1.4 && heroturn) {
            
            monstername.GetComponent<Text>().text = monster1[1].ToString();
            monsterclass.GetComponent<Text>().text = monster1[2].ToString();
            mon1hp = mon1hp - 5;
            if(mon1hp <= 0) {
                //mon1.SetActive(false);
                Destroy(mon1);
                monsterhp.GetComponent<Text>().text = "";
                monstername.GetComponent<Text>().text = "";
                monsterclass.GetComponent<Text>().text = "";
            }
            else if (mon1hp <= 5)
            {
                monsterhp.GetComponent<Text>().color = Color.red;
                monsterhp.GetComponent<Text>().text = mon1hp.ToString();
            }
            else { monsterhp.GetComponent<Text>().text = mon1hp.ToString(); }
            ClickattPosition.nowPosition = new Vector3(100, 100, 100);
            //heroturn = false;
        }
        
        if (Vector3.Distance(ClickattPosition.nowPosition, mon2vt) <= 1.4 && heroturn)
        {
            
            monstername.GetComponent<Text>().text = monster2[1].ToString();
            monsterclass.GetComponent<Text>().text = monster2[2].ToString();
            mon2hp = mon2hp - 5;
            if (mon2hp <= 0)
            {
                //mon1.SetActive(false);
                Destroy(mon2);
                monsterhp.GetComponent<Text>().text = "";
                monstername.GetComponent<Text>().text = "";
                monsterclass.GetComponent<Text>().text = "";
            }
            else if (mon2hp <= 5)
            {
                monsterhp.GetComponent<Text>().color = Color.red;
                monsterhp.GetComponent<Text>().text = mon2hp.ToString();
            }
            else { monsterhp.GetComponent<Text>().text = mon2hp.ToString(); }
            ClickattPosition.nowPosition = new Vector3(100, 100, 100);
            //heroturn = false;
        }

        if (mon1)
        {
            if (mon1.transform.position != MonsterPosition.monsterPosition[0] && mon1.transform.position != MonsterPosition.monsterPosition[1])
            {
                checkmon1pos();

            }
            /*
            if (Vector3.Distance(hero.GetComponent<Transform>().position, mon1vt) > 1.4 && Vector3.Distance(hero.GetComponent<Transform>().position, mon2vt) > 1.4 && heroturn)
            {
                attbtntext.GetComponent<Text>().text = "End turn!";
            }
            else { attbtntext.GetComponent<Text>().text = "Attack!"; }
            */

        }
        else { MonsterPosition.monsterPosition[0] = new Vector3(9, 9, 9); attbtntext.GetComponent<Text>().text = "End turn!"; }
        if (mon2)
        {
            if (mon2.transform.position != MonsterPosition.monsterPosition[0] && mon2.transform.position != MonsterPosition.monsterPosition[1])
            {
                checkmon2pos();
            }
            /*
            if (Vector3.Distance(hero.GetComponent<Transform>().position, mon1vt) > 1.4 && Vector3.Distance(hero.GetComponent<Transform>().position, mon2vt) > 1.4 && heroturn)
            {
                attbtntext.GetComponent<Text>().text = "End turn!";
            }
            else { attbtntext.GetComponent<Text>().text = "Attack!"; }
            */
        }
        else { MonsterPosition.monsterPosition[1] = new Vector3(9, 9, 9); attbtntext.GetComponent<Text>().text = "End turn!"; }
        
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
        /*
        if (heroturn) { movebtn.SetActive(true); attbtn.SetActive(true); }
        else
        {
            movebtn.SetActive(false); attbtn.SetActive(false);
            if (ClickattPosition.canmove)
            {
                Invoke("monstermove", 2.0f);
                //monstermove();
                //StartCoroutine("monstermove");
                ClickattPosition.canmove = false;
                heroturn = true;
            }
            
        }
        */
        
        //------------------------------
        Debug.Log(MonsterPosition.monsterPosition.Count);
    }
    void checkmon1pos()
    {
       
     MonsterPosition.monsterPosition[0] = mon1.transform.position;
      
    }
    void checkmon2pos()
    { 
        MonsterPosition.monsterPosition[1] = mon2.transform.position;    
    }
    public void monstermove()
    {
        //yield return new WaitForSeconds(2);
        //mon1
        Vector3 dest1 = new Vector3(mon1.transform.position.x + (int)Random.Range(-2.0F, 2.0F), mon1.transform.position.y, mon1.transform.position.z + (int)Random.Range(-2.0F, 2.0F));
        Vector3 dest2 = new Vector3(mon2.transform.position.x + (int)Random.Range(-2.0F, 2.0F), mon2.transform.position.y, mon2.transform.position.z + (int)Random.Range(-2.0F, 2.0F));
        if(dest1!= dest2 &&  dest1!= hero.GetComponent<Transform>().position && dest2 != hero.GetComponent<Transform>().position)
        {
            mon1.transform.position = dest1;
            mon2.transform.position = dest2;
           
            CancelInvoke("monstermove");
            
        }
        else
        {
            Invoke("monstermove", 0.1f);
        }
        //mon1 move
        

    }
    

}
