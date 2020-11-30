using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answerAudioController : MonoBehaviour
{
    public AudioClip[] right;
    public AudioClip[] wrong;
    public void answer(bool rightFlag)
    {
        int index;
        if (rightFlag)
        {
            index = Random.Range(0, 100);
            this.GetComponent<AudioSource>().clip = right[index % right.Length];
        }
        else
        {
            index = Random.Range(0, 100);
            this.GetComponent<AudioSource>().clip = wrong[index % wrong.Length];

        }
        this.GetComponent<AudioSource>().Play();

    }
}
