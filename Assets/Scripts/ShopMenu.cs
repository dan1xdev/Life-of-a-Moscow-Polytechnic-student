using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ShopMenu : MonoBehaviour
{

    [SerializeField] Button bimg;
    [SerializeField] Button bimg2;
    [SerializeField] Button bimg3;
    [SerializeField] Button bimg4;
    [SerializeField] bool is_img;

    [SerializeField] bool is_img2;
    [SerializeField] bool is_img3;
    [SerializeField] bool is_img4;
    void Start()
    {
        is_img = PlayerPrefs.GetInt("is_img") == 1 ? true : false;
        if (is_img == true)
        {
            bimg.interactable = false;
        }
        else
        {
            bimg.interactable = true;
        }
        is_img2 = PlayerPrefs.GetInt("is_img2") == 1 ? true : false;
        if (is_img2 == true)
        {
            bimg2.interactable = false;
        }
        else
        {
            bimg2.interactable = true;
        }
        is_img3 = PlayerPrefs.GetInt("is_img3") == 1 ? true : false;
        if (is_img3 == true)
        {
            bimg3.interactable = false;
        }
        else
        {
            bimg3.interactable = true;
        }
        is_img4 = PlayerPrefs.GetInt("is_img4") == 1 ? true : false;
        if (is_img4 == true)
        {
            bimg4.interactable = false;
        }
        else
        {
            bimg4.interactable = true;
        }

    }

    public void ToMainMenu() //загрузка сцены меню
    {
        SceneManager.LoadScene(0);
    }
    public void buyFirst()
    {
        int money = PlayerPrefs.GetInt("money");
        is_img = PlayerPrefs.GetInt("is_img") == 1 ? true : false;
        if (money >= 4000000 && !is_img)
        {
            money -= 4000000;
            PlayerPrefs.SetInt("money", money);
            is_img = true;
            PlayerPrefs.SetInt("is_img", is_img ? 1 : 0);
        }


    }


    public void buySecond()
    {
        int money = PlayerPrefs.GetInt("money");
        is_img2 = PlayerPrefs.GetInt("is_img2") == 1 ? true : false;
        if (money >= 2000000 && !is_img2)
        {
            money -= 2000000;
            PlayerPrefs.SetInt("money", money);
            is_img2 = true;
            PlayerPrefs.SetInt("is_img2", is_img2 ? 1 : 0);
        }
    }
    public void buyThird()
    {
        int money = PlayerPrefs.GetInt("money");
        is_img3 = PlayerPrefs.GetInt("is_img3") == 1 ? true : false;
        if (money >= 1000000 && !is_img3)
        {
            money -= 1000000;
            PlayerPrefs.SetInt("money", money);
            is_img3 = true;
            PlayerPrefs.SetInt("is_img3", is_img3 ? 1 : 0);
        }
    }
    public void buyFourth()
    {
        int money = PlayerPrefs.GetInt("money");
        is_img4 = PlayerPrefs.GetInt("is_img4") == 1 ? true : false;
        if (money >= 100000 && !is_img4)
        {
            money -= 100000;
            PlayerPrefs.SetInt("money", money);
            is_img4 = true;
            PlayerPrefs.SetInt("is_img4", is_img4 ? 1 : 0);
        }
    }
    void Update()
    {

    }
}
