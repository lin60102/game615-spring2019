using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class MonsterPosition : MonoBehaviour
{

    public static int mIndex = 0;   
    //public GameObject mon1, mon2;

    public static List<Vector3> monsterPosition = new List<Vector3>();  


    void Start()
    {
       
        monsterPosition.Insert(mIndex, this.transform.position);    
        mIndex++;   

    }
    void Update()
    {
        


    }
  
}
