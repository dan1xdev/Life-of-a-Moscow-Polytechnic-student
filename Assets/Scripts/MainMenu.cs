using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] int money;
    [SerializeField] int stipendia;
    [SerializeField] bool is_img;
    [SerializeField] bool is_img2;
    [SerializeField] bool is_img3;
    [SerializeField] bool is_img4;
    [SerializeField] bool is_ach1;
    [SerializeField] bool is_ach2;
    [SerializeField] bool is_ach3;
    [SerializeField] bool is_ach4;
    public Image img;
    public Image img2;
    public Image img3;
    public Image img4;



    public int total_money;
    public Text moneyText;

    private void Start()
    {
        stipendia = PlayerPrefs.GetInt("stipendia");
        money = PlayerPrefs.GetInt("money");
        total_money = PlayerPrefs.GetInt("total_money");
        is_img = PlayerPrefs.GetInt("is_img") == 1 ? true : false;
        is_ach1 = PlayerPrefs.GetInt("is_ach1") == 1 ? true : false;
        if (!is_img)
        {
            img.enabled = false;
        }
        else
        {
            img.enabled = true;
            StartCoroutine(IdleFarm());
        }
        is_img2 = PlayerPrefs.GetInt("is_img2") == 1 ? true : false;
        if (!is_img2)
        {
            img2.enabled = false;
        }
        else
        {
            img2.enabled = true;
            StartCoroutine(IdleFarm2());
        }
        is_img3 = PlayerPrefs.GetInt("is_img3") == 1 ? true : false;
        if (!is_img3)
        {
            img3.enabled = false;
        }
        else
        {
            img3.enabled = true;
            StartCoroutine(IdleFarm3());
        }
        is_img4 = PlayerPrefs.GetInt("is_img4") == 1 ? true : false;
        if (!is_img4)
        {
            img4.enabled = false;
        }
        else
        {
            img4.enabled = true;
            StartCoroutine(IdleFarm4());
        }
    }

    public void ButtonClickForIMG() //нажатие кнопки денег
    {
        total_money += 1000000;
        money += 1000000;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("total_money", total_money);
    }
    public void OffButtonClickForIMG() //нажатие кнопки денег
    {
        money = 0;
        total_money = 0;
        is_ach1 = false;
        is_ach2 = false;
        is_ach3 = false;
        is_ach4 = false;
        stipendia = 0;
        PlayerPrefs.SetInt("stipendia", stipendia);
        PlayerPrefs.SetInt("is_ach1", is_ach1 ? 1 : 0);
        PlayerPrefs.SetInt("is_ach2", is_ach1 ? 1 : 0);
        PlayerPrefs.SetInt("is_ach3", is_ach1 ? 1 : 0);
        PlayerPrefs.SetInt("is_ach4", is_ach1 ? 1 : 0);
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("total_money", total_money);
        is_img = false;
        PlayerPrefs.SetInt("is_img", is_img ? 1 : 0);
        is_img2 = false;
        PlayerPrefs.SetInt("is_img2", is_img2 ? 1 : 0);
        is_img3 = false;
        PlayerPrefs.SetInt("is_img3", is_img3 ? 1 : 0);
        is_img4 = false;
        PlayerPrefs.SetInt("is_img4", is_img4 ? 1 : 0);
    }
    public void ButtonClick() //нажатие кнопки денег
    {
        money += stipendia;
        total_money += stipendia;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("total_money", total_money);
    }
    public void ToAchievments() //загрузка сцены достижений
    {
        SceneManager.LoadScene(1);
    }
    public void ToShop() //загрузка сцены достижений
    {
        SceneManager.LoadScene(2);
    }
    public void ToFaq() //загрузка сцены достижений
    {
        SceneManager.LoadScene(3);
    }
    IEnumerator IdleFarm()
    {
        yield return new WaitForSeconds(1);
        money = money + 10000;
        total_money = total_money + 10000;
        PlayerPrefs.SetInt("money", money);
        StartCoroutine(IdleFarm());
    }
    IEnumerator IdleFarm2()
    {
        yield return new WaitForSeconds(1);
        money = money + 5000;
        total_money = total_money + 5000;
        PlayerPrefs.SetInt("money", money);
        StartCoroutine(IdleFarm2());
    }
    IEnumerator IdleFarm3()
    {
        yield return new WaitForSeconds(1);
        money = money + 2000;
        total_money = total_money + 2000;
        PlayerPrefs.SetInt("money", money);
        StartCoroutine(IdleFarm3());
    }
    IEnumerator IdleFarm4()
    {
        yield return new WaitForSeconds(1);
        money = money + 500;
        total_money = total_money + 500;
        PlayerPrefs.SetInt("money", money);
        StartCoroutine(IdleFarm4());
    }
    void Update()
    {
        moneyText.text = money.ToString() + "₽";
    }
}
