using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreController : MonoBehaviour
{
    private int quiz1 = 0, quiz2 = 0, quiz3 = 0;

    public bool city = false;
    public Text vol1, vol2, vol3;
    public Image vol1img, vol2img, vol3img;
    private void OnEnable()
    {
        if (city)
        {
            vol1.text = totalVol1().ToString() + "%";
            vol2.text = totalVol2().ToString() + "%";
            vol3.text = totalVol3().ToString() + "%";
            vol1img.fillAmount = (float)totalVol1() / 100.0f;
            vol2img.fillAmount = (float)totalVol2() / 100.0f;
            vol3img.fillAmount = (float)totalVol3() / 100.0f;
        }
    }
    public void selectVol1()
    {
        PlayerPrefs.SetInt("KSAselectVol1", 20);
    }
    public void selectVol1Tour()
    {
        PlayerPrefs.SetInt("KSAselectVol1Tour", 20);
    }
    public void selectVol1InterAction()
    {
        PlayerPrefs.SetInt("KSAselectVol1InterAction", 30);
    }
    public void selectVol1Quiz(int value)
    {
        quiz1 += value;
        if (quiz1 <= 30)
            PlayerPrefs.SetInt("KSAselectVol1Quiz", quiz1);
    }
    public void selectVol1QuizReset()
    {
        quiz1 = 0;
        PlayerPrefs.SetInt("KSAselectVol1Quiz", 0);
    }
    public int totalVol1()
    {
        return PlayerPrefs.GetInt("KSAselectVol1") + PlayerPrefs.GetInt("KSAselectVol1Tour") + PlayerPrefs.GetInt("KSAselectVol1InterAction") + PlayerPrefs.GetInt("KSAselectVol1Quiz");
    }


    /***** Vol2******/
    public void selectVol2()
    {
        PlayerPrefs.SetInt("KSAselectVol2", 20);
    }
    public void selectVol2Tour()
    {
        PlayerPrefs.SetInt("KSAselectVol2Tour", 20);
    }
    public void selectVol2InterAction()
    {
        PlayerPrefs.SetInt("KSAselectVol2InterAction", 30);
    }
    public void selectVol2Quiz(int value)
    {
        quiz2 += value;
        if (quiz2 <= 30)
            PlayerPrefs.SetInt("KSAselectVol2Quiz", quiz2);
    }
    public void selectVol2QuizReset()
    {
        quiz2 = 0;
        PlayerPrefs.SetInt("KSAselectVol2Quiz", 0);
    }
    public int totalVol2()
    {
        return PlayerPrefs.GetInt("KSAselectVol2") + PlayerPrefs.GetInt("KSAselectVol2Tour") + PlayerPrefs.GetInt("KSAselectVol2InterAction") + PlayerPrefs.GetInt("KSAselectVol2Quiz");
    }

    /***** Vol3*****/
    public void selectVol3()
    {
        PlayerPrefs.SetInt("KSAselectVol3", 20);
    }
    public void selectVol3Tour()
    {
        PlayerPrefs.SetInt("KSAselectVol3Tour", 20);
    }
    public void selectVol3InterAction()
    {
        PlayerPrefs.SetInt("KSAselectVol3InterAction", 30);
    }
    public void selectVol3Quiz(int value)
    {
        quiz3 += value;
        if(quiz3<=30)
        PlayerPrefs.SetInt("KSAselectVol3Quiz", quiz3);
    }
    public void selectVol3QuizReset()
    {
        quiz3 = 0;
        PlayerPrefs.SetInt("KSAselectVol3Quiz", 0);
    }
    public int totalVol3()
    {
        return PlayerPrefs.GetInt("KSAselectVol3") + PlayerPrefs.GetInt("KSAselectVol3Tour") + PlayerPrefs.GetInt("KSAselectVol3InterAction") + PlayerPrefs.GetInt("KSAselectVol3Quiz");
    }
}
