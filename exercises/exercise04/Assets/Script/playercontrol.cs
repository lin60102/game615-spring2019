using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playercontrol : MonoBehaviour
{
    private GameObject ironman;
    private GameObject superman;
    private GameObject start;
    private GameObject level;
    private GameObject label;
    private GameObject end;
    private GameObject endtext;
    private GameObject camera;
    private GameObject fightcamera;
    private GameObject centaur;
    //
    private GameObject enemy_hp;
    private GameObject hero_hp;
    private GameObject hero_sp;
    private GameObject ultbtn;
    //
    public float Speed = 8;
    public float rotateSpeed = 8;
    public GameObject rockfall;
    private Slider hpslider,enemyhpslider;
    private Vector3 curlocation, fightplace_hero, fightplace_enemy, heroscale,btnultscale;
    private Quaternion herorotation;
    private int hero;

        //

        // Start is called before the first frame update
        void Start()
    {
        superman = GameObject.Find("Superman");
        ironman = GameObject.Find("Ironman");
        level= GameObject.Find("level");
        start = GameObject.Find("start");
        camera = GameObject.Find("Main Camera");
        fightcamera = GameObject.Find("Fight_Camera");
        label= GameObject.Find("label");
        endtext = GameObject.Find("endtext");
        end = GameObject.Find("End");
        centaur = GameObject.Find("Centaur");
        hero_hp=GameObject.Find("Hp");
        hero_sp = GameObject.Find("Sp");
        enemy_hp = GameObject.Find("enemyHp");
        ultbtn= GameObject.Find("ultimate");
        btnultscale = new Vector3(1.1401f, 4.6935f,1.0f);
        ultbtn.transform.localScale = Vector3.zero;
        fightcamera.GetComponent<Camera>().enabled = false;
        fightplace_hero = new Vector3 (-483.3f, 18.153f, -419.7f);
        fightplace_enemy = new Vector3(-342f, 18.99f, -419.7f);
        hero_hp.GetComponent<Slider>().onValueChanged.AddListener(listenslider_hero);
        enemy_hp.GetComponent<Slider>().onValueChanged.AddListener(listenslider_enemy);
        hero_sp.GetComponent<Slider>().onValueChanged.AddListener(listenslider_herosp); ;
    }

    // Update is called once per frame
    void Update()
    {
        //move
        //Vector3 forward = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        float horizontal = Input.GetAxis("Horizontal"); //A D 
        float vertical = Input.GetAxis("Vertical"); //W S 
        transform.Translate(Vector3.forward * vertical * Speed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontal * Speed * Time.deltaTime);
        /*
        float inputValue = Mathf.Max(Mathf.Abs(forward.x), Mathf.Abs(forward.z));
        if (inputValue > 0)
        {
            Quaternion lookRot = Quaternion.LookRotation(forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, rotateSpeed * inputValue * Time.deltaTime);
            transform.Translate(Vector3.forward * inputValue * Speed * Time.deltaTime);
        }
        */
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Centaur")
        {
            //camera switch
            camera.GetComponent<Camera>().enabled = false;
            fightcamera.GetComponent<Camera>().enabled =true;
            //fight label on && main label close
            level.GetComponent<CanvasGroup>().alpha = 0;
            level.GetComponent<CanvasGroup>().interactable = false;
            level.GetComponent<CanvasGroup>().blocksRaycasts = false;
            label.GetComponent<CanvasGroup>().alpha = 1;
            label.GetComponent<CanvasGroup>().interactable = true;
            label.GetComponent<CanvasGroup>().blocksRaycasts = true;
            // save location , scale and move to fight place
            curlocation = this.transform.localPosition;
            heroscale = this.transform.localScale;
            herorotation=this.transform.localRotation;
            //Debug.Log(curlocation); testing
            //Debug.Log(herorotation);
            this.transform.localPosition = fightplace_hero;
            Speed = 0; //stop moving
            this.transform.localScale = new Vector3 (transform.localScale.x+20f, transform.localScale.y + 20f, transform.localScale.z + 20f);
            this.transform.localRotation= Quaternion.Euler(0f, 90f, 0f);
            centaur.transform.localPosition = fightplace_enemy;
            centaur.transform.localScale = new Vector3(centaur.transform.localScale.x + 20f, centaur.transform.localScale.y + 20f, centaur.transform.localScale.z + 20f);
            //start fighting

            
        }
        //end game(win or lose)
        
        Debug.Log(enemy_hp.GetComponent<Slider>().value );
        
    }
    public void onbtnnormal_att()
    {
        //att
        enemy_hp.GetComponent<Slider>().value -= 0.25f;
        hero_sp.GetComponent<Slider>().value += 0.25f;

        //enemy_att
        Instantiate(rockfall);
        hero_hp.GetComponent<Slider>().value -= 0.22f;
        hero_sp.GetComponent<Slider>().value += 0.22f;

    }
    public void onbtncritical_att()
    {
        //att
        float crit = Random.Range(0, 1f);
        if (crit >= 0.7)
        {
            enemy_hp.GetComponent<Slider>().value -= 0.45f;
            hero_sp.GetComponent<Slider>().value += 0.45f;

        }
        else
        {
            //miss
        }
        //enemy_att
        hero_hp.GetComponent<Slider>().value -= 0.22f;
        hero_sp.GetComponent<Slider>().value += 0.22f;


    }
    public void onbtnult()
    {
        //att
        enemy_hp.GetComponent<Slider>().value -= 0.6f;
        hero_sp.GetComponent<Slider>().value = 0f;

        //enemy_att
        hero_hp.GetComponent<Slider>().value -= 0.22f;
        

    }
    public void listenslider_enemy(float emeny_value)
    {
        Debug.Log("emeny"+ emeny_value);
              
           if (emeny_value == 0f)
            {
                Destroy(camera);
                endtext.GetComponent<Text>().text = ("You Win");
                end.GetComponent<CanvasGroup>().alpha = 1;
                end.GetComponent<CanvasGroup>().interactable = true;
                end.GetComponent<CanvasGroup>().blocksRaycasts = true;
                label.GetComponent<CanvasGroup>().alpha = 0;
                label.GetComponent<CanvasGroup>().interactable = false;
                label.GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
        
                
    }
    public void listenslider_herosp(float hero_spvalue)
    {
        Debug.Log("herosp" + hero_spvalue+ btnultscale  );
        if (hero_spvalue == 1.0f)
        {
            ultbtn.transform.localScale = btnultscale;
        }
    }
    public void listenslider_hero(float hero_value)
    {
        Debug.Log("hero" + hero_value);
        if (hero_value == 0f)
        {
            Destroy(camera);
            endtext.GetComponent<Text>().text = ("You Dead");
            end.GetComponent<CanvasGroup>().alpha = 1;
            end.GetComponent<CanvasGroup>().interactable = true;
            end.GetComponent<CanvasGroup>().blocksRaycasts = true;
            label.GetComponent<CanvasGroup>().alpha = 0;
            label.GetComponent<CanvasGroup>().interactable = false;
            label.GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
    }
    public void onbtnsuperman()
    {
        hero = 0;
        start.GetComponent<CanvasGroup>().alpha = 0;
        start.GetComponent<CanvasGroup>().interactable = false;
        start.GetComponent<CanvasGroup>().blocksRaycasts = false;
        level.GetComponent<CanvasGroup>().alpha = 1;
        level.GetComponent<CanvasGroup>().interactable = true;
        level.GetComponent<CanvasGroup>().blocksRaycasts = true;
        camera.GetComponent<cameramove>().target = superman.transform;
        Destroy(ironman);
        //float y = (camera.transform.localPosition.y) - 200f;
        //camera.transform.localPosition = new Vector3((camera.transform.localPosition.x),y , (camera.transform.localPosition.z));
    }
    public void onbtnironman()
    {
        hero = 1;
        start.GetComponent<CanvasGroup>().alpha = 0;
        start.GetComponent<CanvasGroup>().interactable = false;
        start.GetComponent<CanvasGroup>().blocksRaycasts = false;
        level.GetComponent<CanvasGroup>().alpha = 1;
        level.GetComponent<CanvasGroup>().interactable = true;
        level.GetComponent<CanvasGroup>().blocksRaycasts = true;
        camera.GetComponent<cameramove>().target = ironman.transform;
        Destroy(superman);
        //float y = (camera.transform.localPosition.y) - 200f;
        //camera.transform.localPosition = new Vector3((camera.transform.localPosition.x), y, (camera.transform.localPosition.z));
    }
}
