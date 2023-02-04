using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine;

public class director : MonoBehaviour
{
    public TMPro.TextMeshProUGUI eggsCount;
    public GameObject[] gos;
    public GameObject[] goPrefab;
    private List<GameObject> obstacles;
    public GameObject fjall;
    public GameObject mountain;
    public GameObject player;
    private PointEffector2D pe;
    
    void Start()
    {
        gos = GameObject.FindGameObjectsWithTag("obstacle");
        obstacles = new List<GameObject>();
        //InvokeRepeating("spawnItem", 5, 5);
        InvokeRepeating("spawnObstacle", 5, 5);
        pe = fjall.GetComponent<PointEffector2D>();
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
        //if (obstacles.Count < 5)
        //{
        //    //Vector3(1.33700001,-5.67000008,-2)
        //    go.transform.position = new Vector3(1.337f, -5.67f, -2.0f);
        //    Instantiate(go);
        //    obstacles.Add(go);
        //}
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
            //pe.forceMagnitude = pe.forceMagnitude != 10 ? 10 : -20;
            pe.forceMagnitude = 15;
            //if (pe.forceMagnitude >= 15)
            //{
            //    pe.forceMagnitude = 15;
            //}
            //if (1 <= pe.forceMagnitude && pe.forceMagnitude < 15)
            //{
            //    pe.forceMagnitude *= 3;
            //}
            //
            //if (pe.forceMagnitude < 1)
            //{
            //    pe.forceMagnitude = 1;
            //}
            
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
            mountain.transform.Translate(0, 0.01f, 0);
            Debug.Log("Size of obstacles: " + obstacles.Count);
            Debug.Log("Size of gos: " + gos.Count());

            for (int i = 0; i < gos.Count(); i++)
            {
                gos[i].transform.Translate(0, 0.01f, 0);
            }
            
            //for (int i = 0; i < obstacles.Count; i++)
            //{
            //    Debug.Log("heyo");
            //    //obstacles[i].transform.position = new Vector3(1.91f, 0.16f, 0);
            //    //obstacles[i].transform.Translate(0, 0.01f, 0);
            //    GameObject obstacle = obstacles[i];
            //    obstacle.transform.position = new Vector3(1.91f, 0.16f, -2);
            //}
            
            //foreach (var obstacle in obstacles)
            //{
            //    obstacle.transform.Translate(0, 0.01f, 0);
            //}
            //Debug.Log("touching");
        }
    }
}
