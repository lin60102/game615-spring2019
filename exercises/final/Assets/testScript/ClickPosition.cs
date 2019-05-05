using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class ClickPosition : MonoBehaviour {

	public Material chessColor;	//用來放棋盤格顏色的材質球
    public GameObject btnmove;
	public static int mSave = 0;	//暫存探索位置的 m 值,用於比較大小
	public static int targetChess = 0;	//存取aaa陣列的引數
	private int i = 0;	//迴圈計數用

	public static bool ChessBoard = false; //為true時,隱藏大棋盤
	public static bool chose = false;	//防止移動中偵測到滑鼠"左鍵"被點擊的誤判
	public static bool delete = false;	//用於判斷刪除棋盤的時機

	public static List<Vector3> aaa = new List<Vector3>();	//用來儲存最短路徑的陣列





	void Start()
	{

        btnmove = GameObject.Find("Move");
    }



	void Update()
	{
		if(delete == true)	//計算完最短行走路徑後
			Destroy (gameObject);	//刪除本地物件(意即ChessBox)

	
	}


	void OnMouseDown()
	{
        btnmove.SetActive(false);
        Vector3 nowPosition = this.transform.position;	//設定nowPosition = 被按下的座標
	
		//先記錄目前點下的位置,它的 m 值是多少
		for (int z = 0; z < Path.Count; z++) 
		{
			//在座標陣列裡,找尋和nowPosition座標相同的格子
			if((nowPosition.x == Path.ppp[z].x) && (nowPosition.z == Path.ppp[z].z))	
			{

				mSave = Path.mCount[z];	//暫存這格的 m 值
				aaa.Insert (targetChess,Path.ppp[z]);	//把這格的座標值,儲存到aaa陣列裡
				targetChess++;	//把存取用的索引值+1
			}
		}

		//Debug.Log ("mSave = " + mSave); //可以確認被點下的那格的 m 值是多少

		while((nowPosition.x != Path.ppp[0].x) || (nowPosition.z != Path.ppp[0].z))	//直到走回Player的位置為止
		{

			for(i = 0; i < Path.Count; i++)	//迴圈最大值 = ppp[]的最大值-1(因為最後一個是空的) = Count
			{
				//向上探索
				if((nowPosition.z + 1 == Path.ppp[i].z) && (nowPosition.x == Path.ppp[i].x))
					cmpM();	//比較探索方向的 m(剩餘行動力) 值，是否比前一個探索方向的 m(剩餘行動力) 值大

				//向下探索
				if((nowPosition.z - 1 == Path.ppp[i].z) && (nowPosition.x == Path.ppp[i].x))
					cmpM();

				//向左探索
				if((nowPosition.x - 1 == Path.ppp[i].x) && (nowPosition.z == Path.ppp[i].z))
					cmpM();

				//向右探索
				if((nowPosition.x + 1 == Path.ppp[i].x) && (nowPosition.z == Path.ppp[i].z))
					cmpM();	

			}

			nowPosition = aaa[targetChess];	//更換nowPosition的位置為 m 值最大的位置
			targetChess++;	//探索完一遍後,把儲存用的引數+1

		}
	
			
		


		delete = true;	
		Path.camera = false;	
		chose = true;	
		Path.cancel = false;	
		ChessBoard = true;	


	}

//--------------------------------------------------------------------------------------

	void cmpM()	//比較探索方向的 m(剩餘行動力) 值，是否比前一個探索方向的 m(剩餘行動力) 值大
	{
		if(Path.mCount[i] > mSave )
		{
			mSave = Path.mCount[i];	//如果比較大，就把mSave換成比較大的
			aaa.Insert (targetChess,Path.ppp[i]); //把 m 值比較大的那格的座標丟入陣列,取代 m 值比較小的那格的座標
		}
	}


//--------------------------------------------------------------------------------------




}
