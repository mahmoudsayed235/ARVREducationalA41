using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class remoteController : MonoBehaviour
{
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Back)||Input.GetKeyDown(KeyCode.Escape))
        {
            loadScene("city 2019");
        }

    }
    void loadScene(string sceneName)
    {
        //Start loading the Scene asynchronously and output the progress bar
        StartCoroutine(LoadScene(sceneName));
    }

    IEnumerator LoadScene(string sceneName)
    {
        yield return null;

        //Begin to load the Scene you specify
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);
        //Don't let the Scene activate until you allow it to
        asyncOperation.allowSceneActivation = false;
        Debug.Log("Pro :" + asyncOperation.progress);
        //When the load is still in progress, output the Text and progress bar
        while (!asyncOperation.isDone)
        {
            //Output the current progress
            //loader.fillAmount = asyncOperation.progress;

            // Check if the load has finished
            if (asyncOperation.progress >= 0.90f)
            {
                //Change the Text to show the Scene is ready
                //m_Text.text = "Press the space bar to continue";
                //Wait to you press the space key to activate the Scene
                //if (Input.GetKeyDown(KeyCode.Space))
                //Activate the Scene
                PlayerPrefs.SetInt("ScreensStart", index);

                asyncOperation.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}
