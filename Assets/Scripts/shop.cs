using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    public Button btnBuyTrousers;
    public Button btnBuyFartPack;
    public Button btnBuyBagPack;
    public Button btnFreeEggs;
    public Button btnStartGame;
    public int priceTrousers;
    public int priceFartPack;
    public int priceBagPack;
    public int slotsTrousers;
    public int slotsBagPack;
    public TMPro.TextMeshProUGUI eggsText;
    //private SoundManager soundManager;
    
    public void Start()
    {
        //PlayerPrefs.SetInt("eggs", 42);
        //PlayerPrefs.SetInt("max_eggs", 42);
        btnBuyTrousers.onClick.AddListener(buyTrousers);
        btnBuyBagPack.onClick.AddListener(buyBagPack);
        btnBuyFartPack.onClick.AddListener(buyFartPack);
        btnFreeEggs.onClick.AddListener(freeEggs);
        //btnStartGame.onClick.AddListener(startGame);
        //updateEggsText();
        //FindObjectOfType<SoundManager>().Play("welcome");
        //soundManager = FindObjectOfType<SoundManager>();
    }

    //private void updateEggsText()
    //{
    //    eggsText.text = "Eggs: " + PlayerPrefs.GetInt("eggs") + " / " + PlayerPrefs.GetInt("max_eggs");
    //}
    
    public void FixedUpdate()
    {
        //Debug.Log("Eggs: " + PlayerPrefs.GetInt("eggs"));
        //updateEggsText();
    }

    public void freeEggs()
    {
        PlayerPrefs.SetInt("eggs", PlayerPrefs.GetInt("max_eggs"));
        eggsText.text = "Eggs: " + PlayerPrefs.GetInt("eggs") + " / " + PlayerPrefs.GetInt("max_eggs");
    }

    public void buyTrousers()
    {
        int eggs = PlayerPrefs.GetInt("eggs");
        int maxEggs = PlayerPrefs.GetInt("max_eggs");
        
        if (eggs >= priceTrousers)
        {
            Debug.Log("hey");
            PlayerPrefs.SetInt("eggs", eggs - priceTrousers);
            PlayerPrefs.SetInt("max_eggs", maxEggs + slotsTrousers);
            //updateEggsText();
            eggsText.text = "Eggs: " + PlayerPrefs.GetInt("eggs") + " / " + PlayerPrefs.GetInt("max_eggs");
            SoundManager.instance.Play("Theme");
        }
    }
    
    public void buyBagPack()
    {
        int eggs = PlayerPrefs.GetInt("eggs");
        int maxEggs = PlayerPrefs.GetInt("max_eggs");
        
        if (eggs >= priceBagPack)
        {
            PlayerPrefs.SetInt("eggs", eggs - priceBagPack);
            PlayerPrefs.SetInt("max_eggs", maxEggs + slotsBagPack);
            eggsText.text = "Eggs: " + PlayerPrefs.GetInt("eggs") + " / " + PlayerPrefs.GetInt("max_eggs");
            //updateEggsText();
        }
    }

    public void buyFartPack()
    {
        int eggs = PlayerPrefs.GetInt("eggs");
        int maxEggs = PlayerPrefs.GetInt("max_eggs");
        
        if (eggs >= priceFartPack)
        {
            PlayerPrefs.SetInt("eggs", eggs - priceFartPack);
            eggsText.text = "Eggs: " + PlayerPrefs.GetInt("eggs") + " / " + PlayerPrefs.GetInt("max_eggs");
            //updateEggsText();
        }
    }

    public void startGame()
    {
        Debug.Log("yoyo");
        AudioListener al = FindObjectOfType<AudioListener>();
        Destroy(al);
        SceneManager.LoadScene("magneto", LoadSceneMode.Single);
    }
}
