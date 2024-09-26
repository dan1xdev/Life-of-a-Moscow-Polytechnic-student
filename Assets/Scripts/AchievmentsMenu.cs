using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AchievmentsMenu : MonoBehaviour
{
    [SerializeField] bool is_ach1;
    [SerializeField] Button ach1;
    [SerializeField] bool is_ach2;
    [SerializeField] Button ach2;
    [SerializeField] bool is_ach3;
    [SerializeField] Button ach3;
    [SerializeField] bool is_ach4;
    [SerializeField] Button ach4;
    [SerializeField] int stipendia;
    void Start()
    {
        is_ach1 = PlayerPrefs.GetInt("is_ach1") == 1 ? true : false;
        if (is_ach1 == true)
        {
            ach1.interactable = false;
        }
        else
        {
            ach1.interactable = true;
        }
        is_ach2 = PlayerPrefs.GetInt("is_ach2") == 1 ? true : false;
        if (is_ach2 == true)
        {
            ach2.interactable = false;
        }
        else
        {
            ach2.interactable = true;
        }
        is_ach3 = PlayerPrefs.GetInt("is_ach3") == 1 ? true : false;
        if (is_ach3 == true)
        {
            ach3.interactable = false;
        }
        else
        {
            ach3.interactable = true;
        }
        is_ach4 = PlayerPrefs.GetInt("is_ach4") == 1 ? true : false;
        if (is_ach4 == true)
        {
            ach4.interactable = false;
        }
        else
        {
            ach4.interactable = true;
        }
    }

    public void ToMainMenu() //загрузка сцены меню
    {
        SceneManager.LoadScene(0);
    }
    public void FirstAch()
    {
        is_ach1 = PlayerPrefs.GetInt("is ach1") == 1 ? true : false;
        if (!is_ach1)
        {
            stipendia = 2200;
            PlayerPrefs.SetInt("stipendia", stipendia);
            is_ach1 = true;
            PlayerPrefs.SetInt("is_ach1", is_ach1 ? 1 : 0);
        }
    }
    public void SecondAch()
    {
        int total_money = PlayerPrefs.GetInt("total_money");
        is_ach2 = PlayerPrefs.GetInt("is ach2") == 1 ? true : false;
        if (!is_ach2 && total_money >= 20000)
        {
            stipendia = 4200;
            PlayerPrefs.SetInt("stipendia", stipendia);
            is_ach2 = true;
            PlayerPrefs.SetInt("is_ach2", is_ach2 ? 1 : 0);
        }
    }
    public void ThirdAch()
    {
        int total_money = PlayerPrefs.GetInt("total_money");
        is_ach3 = PlayerPrefs.GetInt("is ach3") == 1 ? true : false;
        if (!is_ach3 && total_money >= 100000)
        {
            stipendia = 10000;
            PlayerPrefs.SetInt("stipendia", stipendia);
            is_ach3 = true;
            PlayerPrefs.SetInt("is_ach3", is_ach3 ? 1 : 0);
        }
    }
    public void FourthAch()
    {
        int total_money = PlayerPrefs.GetInt("total_money");
        is_ach4 = PlayerPrefs.GetInt("is ach4") == 1 ? true : false;
        if (!is_ach4 && total_money >= 500000)
        {
            stipendia = 20000;
            PlayerPrefs.SetInt("stipendia", stipendia);
            is_ach4 = true;
            PlayerPrefs.SetInt("is_ach4", is_ach4 ? 1 : 0);
        }
    }

    void Update()
    {

    }
}
