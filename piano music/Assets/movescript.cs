using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movescript : MonoBehaviour
{
   //private GameObject[] pianokey;
    
    private GameObject cubedo;
    private GameObject cubere;
    private GameObject cubemi;
    private GameObject cubefa;
    private GameObject cubeso;
    private GameObject cubela;
    private GameObject cubesi;
    private GameObject cubedos;
    private AudioSource source;
    public AudioClip pianoC;
    public AudioClip pianoD;
    public AudioClip pianoE;
    public AudioClip pianoF;
    public AudioClip pianoG;
    public AudioClip pianoA;
    public AudioClip pianoB;
    public AudioClip pianoC2;
    // Start is called before the first frame update\
    void Start()
    {
        //pianokey=GameObject.FindGameObjectsWithTag("pianokey");
        //pianokey= new GameObject[]
        cubedo = GameObject.Find("/pianokey/Do");
        cubere = GameObject.Find("/pianokey/Re");
        cubemi = GameObject.Find("/pianokey/Mi");
        cubefa = GameObject.Find("/pianokey/Fa");
        cubeso = GameObject.Find("/pianokey/So");
        cubela = GameObject.Find("/pianokey/La");
        cubesi = GameObject.Find("/pianokey/Si");
        cubedos = GameObject.Find("/pianokey/DoS");

        source = this.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
	    //for(int i=0;i<;i++){}

            cubere.GetComponent<Renderer>().material.color = Color.white;
            cubemi.GetComponent<Renderer>().material.color = Color.white;
            cubefa.GetComponent<Renderer>().material.color = Color.white;
            cubeso.GetComponent<Renderer>().material.color = Color.white;
            cubela.GetComponent<Renderer>().material.color = Color.white;
            cubesi.GetComponent<Renderer>().material.color = Color.white;
            cubedos.GetComponent<Renderer>().material.color = Color.white;
            cubedo.GetComponent<Renderer>().material.color = Color.blue;
           source.clip = pianoC;
           source.Stop();  
           source.Play();
            
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            cubedo.GetComponent<Renderer>().material.color = Color.white;
            cubere.GetComponent<Renderer>().material.color = Color.blue;
            cubemi.GetComponent<Renderer>().material.color = Color.white;
            cubefa.GetComponent<Renderer>().material.color = Color.white;
            cubeso.GetComponent<Renderer>().material.color = Color.white;
            cubela.GetComponent<Renderer>().material.color = Color.white;
            cubesi.GetComponent<Renderer>().material.color = Color.white;
            cubedos.GetComponent<Renderer>().material.color = Color.white;
            source.clip = pianoD;
            source.Stop();  
            source.Play();  
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            cubedo.GetComponent<Renderer>().material.color = Color.white;
            cubere.GetComponent<Renderer>().material.color = Color.white;
            cubemi.GetComponent<Renderer>().material.color = Color.blue;
            cubefa.GetComponent<Renderer>().material.color = Color.white;
            cubeso.GetComponent<Renderer>().material.color = Color.white;
            cubela.GetComponent<Renderer>().material.color = Color.white;
            cubesi.GetComponent<Renderer>().material.color = Color.white;
            cubedos.GetComponent<Renderer>().material.color = Color.white;
            source.clip = pianoE;
            source.Stop();  
            source.Play();  
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            cubedo.GetComponent<Renderer>().material.color = Color.white;
            cubere.GetComponent<Renderer>().material.color = Color.white;
            cubemi.GetComponent<Renderer>().material.color = Color.white;
            cubefa.GetComponent<Renderer>().material.color = Color.blue;
            cubeso.GetComponent<Renderer>().material.color = Color.white;
            cubela.GetComponent<Renderer>().material.color = Color.white;
            cubesi.GetComponent<Renderer>().material.color = Color.white;
            cubedos.GetComponent<Renderer>().material.color = Color.white;
            source.clip = pianoF;
            source.Stop();  
            source.Play();  
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            cubedo.GetComponent<Renderer>().material.color = Color.white;
            cubere.GetComponent<Renderer>().material.color = Color.white;
            cubemi.GetComponent<Renderer>().material.color = Color.white;
            cubefa.GetComponent<Renderer>().material.color = Color.white;
            cubeso.GetComponent<Renderer>().material.color = Color.blue;
            cubela.GetComponent<Renderer>().material.color = Color.white;
            cubesi.GetComponent<Renderer>().material.color = Color.white;
            cubedos.GetComponent<Renderer>().material.color = Color.white;
            source.clip = pianoG;
            source.Stop();  
            source.Play();  
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            cubedo.GetComponent<Renderer>().material.color = Color.white;
            cubere.GetComponent<Renderer>().material.color = Color.white;
            cubemi.GetComponent<Renderer>().material.color = Color.white;
            cubefa.GetComponent<Renderer>().material.color = Color.white;
            cubeso.GetComponent<Renderer>().material.color = Color.white;
            cubela.GetComponent<Renderer>().material.color = Color.blue;
            cubesi.GetComponent<Renderer>().material.color = Color.white;
            cubedos.GetComponent<Renderer>().material.color = Color.white;
            source.clip = pianoA;
            source.Stop();  
            source.Play();  
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            cubedo.GetComponent<Renderer>().material.color = Color.white;
            cubere.GetComponent<Renderer>().material.color = Color.white;
            cubemi.GetComponent<Renderer>().material.color = Color.white;
            cubefa.GetComponent<Renderer>().material.color = Color.white;
            cubeso.GetComponent<Renderer>().material.color = Color.white;
            cubela.GetComponent<Renderer>().material.color = Color.white;
            cubesi.GetComponent<Renderer>().material.color = Color.blue;
            cubedos.GetComponent<Renderer>().material.color = Color.white;
            source.clip = pianoB;
            source.Stop();  
            source.Play();  
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            cubedo.GetComponent<Renderer>().material.color = Color.white;
            cubere.GetComponent<Renderer>().material.color = Color.white;
            cubemi.GetComponent<Renderer>().material.color = Color.white;
            cubefa.GetComponent<Renderer>().material.color = Color.white;
            cubeso.GetComponent<Renderer>().material.color = Color.white;
            cubela.GetComponent<Renderer>().material.color = Color.white;
            cubesi.GetComponent<Renderer>().material.color = Color.white;
            cubedos.GetComponent<Renderer>().material.color = Color.blue;
            source.clip = pianoC2;
            source.Stop();  
            source.Play();  
        }
    }
}
