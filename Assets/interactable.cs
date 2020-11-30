using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class interactable : MonoBehaviour
{
   // public Image loader;

  //  public SceneController sc = null;
    public void Pressed(string name) {
        if (name == "screen 1")
        {
            loadScene("Vol 1");
        }
        else if (name == "screen 2")
        {
            loadScene("Vol 2");
        }
        else if (name == "screen 3")
        {
            loadScene("Vol 3");
        }
        else
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            bool flip = !renderer.enabled;
            renderer.enabled = flip;
        }
    }
    private void Start()
    {

    }
    string name;
  public void loadScene(string sceneName)
    {
        name = sceneName;
        this.GetComponent<Animator>().SetTrigger("back");
        Invoke("openScene", 8f);
/*
        if (PlayerPrefs.GetString("X")== "false")
        {
            PlayerPrefs.SetString("X", "true");
            PlayerPrefs.SetString("sceneName", sceneName);
            Debug.Log("scene name : " + sceneName);
            this.GetComponent<Animator>().SetTrigger("back");
            Invoke("openScene", 8f);
            //Start loading the Scene asynchronously and output the progress bar
            StartCoroutine(LoadScene(sceneName));
        }
        else if(PlayerPrefs.GetString("X") == "true")
        {
            SceneManager.LoadScene(sceneName);
        }
  */
    }
    AsyncOperation asyncOperation;
    IEnumerator LoadScene(string sceneName)
    {
        yield return null;

        //Begin to load the Scene you specify
        asyncOperation = SceneManager.LoadSceneAsync(sceneName);
        //Don't let the Scene activate until you allow it to
        asyncOperation.allowSceneActivation = false;
        Debug.Log("Pro :" + asyncOperation.progress);
        //When the load is still in progress, output the Text and progress bar
        while (!asyncOperation.isDone)
        {
            //Output the current progress
            //  loader.fillAmount = asyncOperation.progress;

            Debug.Log("Pro :" + asyncOperation.progress);
            // Check if the load has finished
            if (asyncOperation.progress >= 0.90f)
            {
                //Change the Text to show the Scene is ready
                //m_Text.text = "Press the space bar to continue";
                //Wait to you press the space key to activate the Scene
               
            }

            yield return null;
        }
    }
    public void openScene()
    {

        SceneManager.LoadScene(name);
        //asyncOperation.allowSceneActivation = true;
    }
    private void Update()
    {
           if (Input.GetKeyDown(KeyCode.Space))
           {

               loadScene("Vol 1");
           }
      //     Debug.Log("frame rate : " + Application.targetFrameRate);
       
    }
}
