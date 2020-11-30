using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class digestiveQuizSystem : MonoBehaviour
{
    public GameObject[] models;
    public GameObject[] questions;
    
    bool[] flags = { false, false, false };
    public Animator Dsystem;
    public Animator player;
    int activeRandome=0;
    public void createQuestion()
    {
        models[activeRandome].SetActive(false);
        questions[activeRandome].SetActive(false);
        activeRandome =getindex();
        print("activeRandome : " + activeRandome);
        models[activeRandome].SetActive(true);
        questions[activeRandome].SetActive(true);
        this.GetComponent<Animator>().Play("Dplayer3Quiz");

    }
    int getindex()
    {

        int rand;
        while (true)
        {
            rand = ((int)Random.Range(0, 100) % 3);
            if (!flags[rand])
            {
                flags[rand] = true;
                return rand;
            }
        }
    }
    public void answer()
    {
       
        for (int i = 0; i < 3; i++)
           {
                questions[activeRandome].transform.GetChild(i).gameObject.GetComponent<Button>().interactable = false;
           }
        Invoke("answerQuestion",1.0f);
    }
    void answerQuestion()
    {
        
        questions[activeRandome].GetComponent<AudioSource>().Play();
        bool isDone = true;
        for (int i = 0; i < flags.Length; i++)
        {
            if (!flags[i])
            {
                isDone = false;
                this.GetComponent<Animator>().Play("Dplayer3QuizOut");
                Invoke("createQuestion", 1.5f);
                return;
            }
        }
        if (isDone)
        {
            this.GetComponent<Animator>().Play("Dplayer3QuizOut");
            Dsystem.Play("endQuiz");
            Invoke("endQuiz", 1.5f);
        }
    }
    public bool skeleton = false;
    public void startQuiz()
    {
        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                questions[j].transform.GetChild(i).gameObject.GetComponent<Button>().interactable = true;
                if (questions[j].transform.GetChild(i).childCount != 0)
                    questions[j].transform.GetChild(i).GetChild(0).gameObject.GetComponent<Text>().color = Color.white;
            }
        }
        flags[0] = false;
        flags[1] = false;
        flags[2] = false;
        Dsystem.Play("startQuiz");
        if (skeleton)
        {
            Invoke("createQuestion", 3.0f);

        }
        else
        {
            Invoke("createQuestion", 1.0f);
        }
    }
    public void endQuiz()
    {
        models[activeRandome].SetActive(false);
        questions[activeRandome].SetActive(false);
        player.Play("Dplayer3QuizEnd");
    }


    public Color right, wrong;
    public void rightFont(Text text)
    {
        text.color = right;
    }
    public void wrongFont(Text text)
    {
        text.color = wrong;
    }

}
