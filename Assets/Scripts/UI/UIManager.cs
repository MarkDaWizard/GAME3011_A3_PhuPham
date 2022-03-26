using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    public GameObject match3Easy, match3Medium, match3Hard;
    public GameObject gameUI, menuUI;
    public int gameDifficulty = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnEasyButtonClick()
    {
        gameDifficulty = 0;
        gameUI.SetActive(true);
        menuUI.SetActive(false);
        match3Easy.SetActive(true);
        
    }

    public void OnMediumButtonClick()
    {
        gameDifficulty = 1;
        gameUI.SetActive(true);
        menuUI.SetActive(false);
        match3Medium.SetActive(true);
        
    }

    public void OnHardButtonClick()
    {
        gameDifficulty = 2;
        gameUI.SetActive(true);
        menuUI.SetActive(false);
        match3Hard.SetActive(true);
        
    }

    public void OnExitButtonClick()
    {
        Application.Quit();
    }
}
