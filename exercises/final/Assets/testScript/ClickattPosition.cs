using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ClickattPosition : MonoBehaviour {

	public Material chessColor;	//用來放棋盤格顏色的材質球
    
	public static int mSave = 0;	//暫存探索位置的 m 值,用於比較大小
	public static int targetChess = 0;	//存取aaa陣列的引數
	private int i = 0;	//迴圈計數用
    public GameObject btnatt,btnend;
    public static bool ChessBoard = false; //為true時,隱藏大棋盤
	public static bool att = false;	//防止移動中偵測到滑鼠"左鍵"被點擊的誤判
	public static bool delete = false;	//用於判斷刪除棋盤的時機
    public static bool canmove = false;
    public static Vector3 nowPosition;

    public static List<Vector3> aaa = new List<Vector3>();	//用來儲存最短路徑的陣列



//--------------------------------------------------------------------

	void Start()
	{
        btnatt = GameObject.Find("Attact");
        btnend= GameObject.Find("end");

    }

//--------------------------------------------------------------------

	void Update()
	{
        if (delete == true)  //計算完最短行走路徑後
        {
            Destroy(gameObject);
             
        }	//刪除本地物件(意即ChessBox)
        

    }

//---------------------計算最短移動路徑----------------------------------

	void OnMouseDown()
	{
        if (btnatt) { btnatt.SetActive(false); }
        
        nowPosition = this.transform.position;	//設定nowPosition = 被按下的座標
	
		//先記錄目前點下的位置,它的 m 值是多少
		for (int z = 0; z < Path.attCount; z++) 
		{
			//在座標陣列裡,找尋和nowPosition座標相同的格子
			if((nowPosition.x == Path.attppp[z].x) && (nowPosition.z == Path.attppp[z].z))	
			{

				mSave = Path.attmCount[z];	//暫存這格的 m 值
				aaa.Insert (targetChess,Path.attppp[z]);	//把這格的座標值,儲存到aaa陣列裡
				targetChess++;	//把存取用的索引值+1
			}
		}

		//Debug.Log ("mSave = " + mSave); //可以確認被點下的那格的 m 值是多少

		while((nowPosition.x != Path.attppp[0].x) || (nowPosition.z != Path.attppp[0].z))	//直到走回Player的位置為止
		{

			for(i = 0; i < Path.attCount; i++)	//迴圈最大值 = ppp[]的最大值-1(因為最後一個是空的) = Count
			{
				//向上探索
				if((nowPosition.z + 1 == Path.attppp[i].z) && (nowPosition.x == Path.attppp[i].x))
					cmpM();	//比較探索方向的 m(剩餘行動力) 值，是否比前一個探索方向的 m(剩餘行動力) 值大

				//向下探索
				if((nowPosition.z - 1 == Path.attppp[i].z) && (nowPosition.x == Path.attppp[i].x))
					cmpM();

				//向左探索
				if((nowPosition.x - 1 == Path.attppp[i].x) && (nowPosition.z == Path.attppp[i].z))
					cmpM();

				//向右探索
				if((nowPosition.x + 1 == Path.attppp[i].x) && (nowPosition.z == Path.attppp[i].z))
					cmpM();	

			}

			nowPosition = aaa[targetChess];	//更換nowPosition的位置為 m 值最大的位置
			targetChess++;	//探索完一遍後,把儲存用的引數+1

		}


        //for(int j = targetChess - 1; j >= 0; j--)	//可以查看結果正不正確(將路徑搜尋的結果倒印)
        	//Debug.Log ("aaa = " + aaa[j]);

        //Debug.Log ("Destination = " + nowPosition);	//可以查看路徑搜尋的結果,是不是從目標點回到原點
        //nowPosition = new Vector3(0, 0, 0);
        delete = true;	//算完最短路徑之後,將delete設為true,藉此刪除棋盤
		Path.camera = false;	//移動前拉近攝影機
		att = true;	//這時候角色才能開始移動(請見PlayerController的腳本)
		Path.cancel = false;	//令滑鼠"右鍵"的功能失效,防止移動中亂按的誤判
		ChessBoard = true;  //隱藏大棋盤
        canmove = true;


    }

//--------------------------------------------------------------------------------------

	void cmpM()	//比較探索方向的 m(剩餘行動力) 值，是否比前一個探索方向的 m(剩餘行動力) 值大
	{
		if(Path.attmCount[i] > mSave )
		{
			mSave = Path.attmCount[i];	//如果比較大，就把mSave換成比較大的
			aaa.Insert (targetChess,Path.attppp[i]); //把 m 值比較大的那格的座標丟入陣列,取代 m 值比較小的那格的座標
		}
	}


//--------------------------------------------------------------------------------------




}
