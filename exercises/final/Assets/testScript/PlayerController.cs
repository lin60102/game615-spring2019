using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour {


	public int MoveSpeed;  
    private Animator animator;
    
    private int i = 2;
    void Start()
   {
         animator = GetComponent<Animator>();
 
   }

//------------------------------------------------------------------------------------

void Update()
	{
		if(Input.GetButtonDown("Fire1") && ClickPosition.chose == true )	
		{
            animator.SetBool("go", true);
            StartCoroutine (move());	
			ClickPosition.chose = false;	
		
		}
        if (ClickattPosition.att == true)
        {
            animator.SetBool("att", true);
            StartCoroutine(att());
            ClickattPosition.att = false;

        }
    }

    //------------------------------------------------------------------------------------
    public IEnumerator att()
    {
        while (true)
        {

            Vector3 distance = ClickattPosition.aaa[ClickattPosition.targetChess - i] - this.transform.position;

            float len = distance.magnitude;

            distance.Normalize();



            if (distance.x > 0.1f)
                this.transform.eulerAngles = new Vector3(0, 90, 0);


            if (distance.x < -0.1f)
                this.transform.eulerAngles = new Vector3(0, -90, 0);

            if (distance.z > 0.9f)
                this.transform.eulerAngles = new Vector3(0, 0, 0);


            if (distance.z < -0.9f)
                this.transform.eulerAngles = new Vector3(0, 180, 0);


    
/*
            if (len <= (distance.magnitude * Time.deltaTime * 2))
            {

                this.transform.position = ClickattPosition.aaa[ClickattPosition.targetChess - i];
                i++;
                if (ClickattPosition.targetChess - i < 0)
                {
                    i = 2;
                    break;
                }

            }
*/
           
            yield return new WaitForSeconds(1 / MoveSpeed);
            break;
           // this.transform.position = this.transform.position + (distance * Time.deltaTime * 2);
        }

        animator.SetBool("att", false);
        ClickattPosition.delete = false;

        Path.attindex = 0;
        Path.attCount = 0;
        ClickattPosition.mSave = 0;
        ClickattPosition.targetChess = 0;

        Path.attppp.Clear();
        Path.attmCount.Clear();
        ClickattPosition.aaa.Clear();

        //Path.button = true;

        ClickattPosition.ChessBoard = false;


    }
    //------------------------------------------------------------------------------------
    public IEnumerator move()
	{	
		while(true)
		{
            
			Vector3 distance = ClickPosition.aaa[ClickPosition.targetChess - i] - this.transform.position;
			
			float len = distance.magnitude;	
						
			distance.Normalize ();	
				

			
			if(distance.x > 0.1f)
				this.transform.eulerAngles = new Vector3(0,90,0);	

		
			 if(distance.x < -0.1f)
				this.transform.eulerAngles = new Vector3(0,-90,0);	
             
			 if(distance.z > 0.9f)
				this.transform.eulerAngles = new Vector3(0,0,0);

			
			 if(distance.z < -0.9f)
				this.transform.eulerAngles = new Vector3(0,180,0);



			
			if (len <= (distance.magnitude * Time.deltaTime * 2))	
			{
				
				this.transform.position = ClickPosition.aaa[ClickPosition.targetChess - i];	
				i++;	
				if(ClickPosition.targetChess - i < 0)	
				{
					i = 2;	
					break;	
				}
				
			}

			
			yield return new WaitForSeconds(1/MoveSpeed);
			
			this.transform.position = this.transform.position + (distance * Time.deltaTime * 2);
            if (this.transform.position.x > 4) { this.transform.position = new Vector3(4, this.transform.position.y, this.transform.position.z); break; }
            if (this.transform.position.x < -4) { this.transform.position = new Vector3(-4, this.transform.position.y, this.transform.position.z); break; }
            if (this.transform.position.z > 4) { this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 4); break; }
            if (this.transform.position.z < -4) { this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -4); break; }
        }

        animator.SetBool("go", false);
        ClickPosition.delete = false;

		Path.index = 0;
		Path.Count = 0;	
		ClickPosition.mSave = 0;	
		ClickPosition.targetChess = 0;	

		Path.ppp.Clear();	
		Path.mCount.Clear();	
		ClickPosition.aaa.Clear ();

		Path.button = true; 

		ClickPosition.ChessBoard = false; 


	}



}
