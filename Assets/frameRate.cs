using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class frameRate : MonoBehaviour
{
    public int frames=60;
    public scoreController score;
    public AudioSource finishTotal, finishVol, notFinishVol;
    public GameObject startbtn;
     // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = frames;
        int start = PlayerPrefs.GetInt("ScreensStart");
        
        Debug.Log("start : " + start);
        if (start == 1)
        {
            startbtn.SetActive(false);
            finishCourse(1);
            this.GetComponent<Animator>().SetTrigger("one");
            PlayerPrefs.SetInt("ScreensStart", 0);

        }
        else if (start == 2)
        {
            startbtn.SetActive(false);
            finishCourse(2);
            this.GetComponent<Animator>().SetTrigger("two");
                PlayerPrefs.SetInt("ScreensStart", 0);
        }
        else if (start == 3)
        {
            startbtn.SetActive(false);
            finishCourse(3);

            this.GetComponent<Animator>().SetTrigger("three");
                PlayerPrefs.SetInt("ScreensStart", 0);
        }
        else
        {

            PlayerPrefs.SetString("X", "false");
        }




        //SceneManager.UnloadSceneAsync(PlayerPrefs.GetString("sceneName")); 
    }
    void finishCourse(int volNumber)
    {
        if ((score.totalVol1() + score.totalVol2() + score.totalVol3()) == 300)
        {
            finishTotal.Play();
            //azhr screen gdeda ll fada2
        }
        else
        {
            if(volNumber==1)
            {
                if(score.totalVol1() == 100)
                {
                    finishVol.Play();
                }
                else
                {
                    notFinishVol.Play();
                }
            }
            else if (volNumber == 2)
            {

                if (score.totalVol2() == 100)
                {
                    finishVol.Play();
                }
                else
                {
                    notFinishVol.Play();
                }
            }
            else if (volNumber == 3)
            {

                if (score.totalVol3() == 100)
                {
                    finishVol.Play();
                }
                else
                {
                    notFinishVol.Play();
                }
            }
        }
    }
}
