using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
    
{
    public GameObject menu;
    public GameObject player;
    public GameObject shop;
    public GameObject settings;
    public GameObject Buybutton1;
    public GameObject Out;
    public void Start()
    {
        menu.SetActive(true);
        player.SetActive(false);
        shop.SetActive(false);
        settings.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            menu.SetActive(true);
            player.SetActive(false);
        }
    }
    public void Play()
    {
        menu.SetActive(false);
        player.SetActive(true);
        
    }
    public void OpenShopPanel()
    {
        menu.SetActive(false);
        player.SetActive(false);
        shop.SetActive(true);
        settings.SetActive(false);
        Out.SetActive(false);
    }
    public void Buy()
    {
        Buybutton1.SetActive(false);
        Out.SetActive(true);
    }


    public void CloseShopPanel()
    {
        menu.SetActive(true);
        player.SetActive(false);
        shop.SetActive(false);
        settings.SetActive(false);
    }
    public void Opensettings()
    { 
        menu.SetActive(false);
        player.SetActive(false);
        shop.SetActive(false);
        settings.SetActive(true);
    }
    public void Closesettings()
    {   menu.SetActive(true);
        player.SetActive(false);
        shop.SetActive(false);
        settings.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
 
}
