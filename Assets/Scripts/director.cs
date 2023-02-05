using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine;

public class director : MonoBehaviour
{
    public TMPro.TextMeshProUGUI eggsCount;
    public GameObject[] gos;
    public GameObject[] gosEggs;
    public GameObject[] gosRotiEggs;
    public GameObject[] goPrefab;
    private List<GameObject> obstacles;
    public GameObject fjall;
    public GameObject mountain;
    public GameObject player;
    private PointEffector2D pe;
    public float speed;
    public int interval;
    private SoundManager soundManager;
    public Animator animator;

    void Start()
    {
        gos = GameObject.FindGameObjectsWithTag("obstacle");
        obstacles = new List<GameObject>();
        //InvokeRepeating("spawnItem", 5, 5);
        //InvokeRepeating("spawnObstacle", 5, 5);
        Invoke("spawnObstacle", 2);
        pe = fjall.GetComponent<PointEffector2D>();
        BoxCollider2D bc = player.GetComponent<BoxCollider2D>();
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
        soundManager = FindObjectOfType<SoundManager>();
        eggsCount.text = "Eggs: " + PlayerPrefs.GetInt("eggs");
        SoundManager.instance.Play("music");
        InvokeRepeating("cleanup", 1, 2);
    }

    void cleanup()
    {
        Debug.Log("Cleaning...");
        cleanupArray(gos);
        cleanupArray(gosEggs);
        cleanupArray(gosRotiEggs);
    }
    
    void cleanupArray(GameObject[] gos)
    {
        for (int i = 0; i < gos.Length; i++)
        {
            if (gos[i].transform.position.x < -100 ||
                gos[i].transform.position.x > 100 ||
                gos[i].transform.position.y < -100 ||
                gos[i].transform.position.y > 100)
            {
                Debug.Log("Cleaned GO with tag: " + gos[i].tag);
                Destroy(gos[i]);
            }
        }
    }
    
    void spawnObstacle()
    {
        //GameObject[] gos;
        //GameObject go = Resources.Load("Prefabs/Obstacles/eggstacle", typeof(GameObject)) as GameObject;
        //go.transform.position = new Vector3(1.337f, -5.67f, -2.0f);
        var index = Random.Range(0, goPrefab.Length);
        var goObject = Instantiate(goPrefab[index]);

        goObject.transform.position = new Vector3(1.337f, -5.67f, -2.0f);

        gos = GameObject.FindGameObjectsWithTag("obstacle");
        gosEggs = GameObject.FindGameObjectsWithTag("egg");
        gosRotiEggs = GameObject.FindGameObjectsWithTag("rotiegg");
        //if (obstacles.Count < 5)
        //{
        //    //Vector3(1.33700001,-5.67000008,-2)
        //    go.transform.position = new Vector3(1.337f, -5.67f, -2.0f);
        //    Instantiate(go);
        //    obstacles.Add(go);
        //}
        Invoke("spawnObstacle", Random.Range(1.0f, 3.3f));
    }
    
    //void spawnItem()
    //{
    //    if (gos.Count < 10)
    //    {
    //        GameObject go = Resources.Load("Prefabs/lundi", typeof(GameObject)) as GameObject;
    //        Debug.Log(go);
    //        if (go == null)
    //        {
    //            Debug.Log("Lundi is null");
    //        }
    //        else
    //        {
    //            Debug.Log("Lundi is not null");
    //            Instantiate(go);
    //        }
    //        //player.transform.GetPositionAndRotation();
    //        //go.transform.se
    //        //gos.Add(go);
    //    }
    //}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            eggsCount.text = "Eggs: " + PlayerPrefs.GetInt("eggs");
            SoundManager.instance.Play("lora");
            pe.forceMagnitude = 15;
            animator.SetFloat("Speed", Mathf.Abs(pe.forceMagnitude));
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            pe.forceMagnitude = -25;
            

        }

    }

    private void FixedUpdate()
    {
        if (!fjall.GetComponent<BoxCollider2D>().IsTouching(player.GetComponent<BoxCollider2D>()))
        {
            mountain.transform.Translate(0, speed, 0);

            for (int i = 0; i < gos.Count(); i++)
            {
                try
                {
                    gos[i].transform.Translate(0, speed, 0);
                }
                catch (MissingReferenceException e)
                {
                    
                }
            }
            for (int i = 0; i < gosEggs.Count(); i++)
            {
                try
                {
                    gosEggs[i].transform.Translate(0, speed, 0);
                }
                catch (MissingReferenceException e)
                {
                    
                }
            }
            for (int i = 0; i < gosRotiEggs.Count(); i++)
            {
                try
                {
                    gosRotiEggs[i].transform.Translate(0, speed, 0);
                }
                catch (MissingReferenceException e)
                {
                    
                }
            }
        } 

        //if (!isGrounded)
        //{
        //    Debug.Log("Not grounded");
            
        //}
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("ground"))
    //    {
    //        isGrounded = true;
    //    }
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("ground"))
    //    {
    //        isGrounded = false;
    //    }
    //}



}
