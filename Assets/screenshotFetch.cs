using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenshotFetch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      /*  Texture2D texture = ScreenCapture.CaptureScreenshotAsTexture();
        //Sprite tempSprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero, 0);
        this.gameObject.GetComponent<RawImage>().texture= texture;
*/
    }
    IEnumerator RecordFrame()
    {
        yield return new WaitForEndOfFrame();
        var texture = ScreenCapture.CaptureScreenshotAsTexture();
        // do something with texture
        this.gameObject.GetComponent<RawImage>().texture = texture;

        // cleanup
       // Object.Destroy(texture);
    }

    public void OnEnable()
    {
        StartCoroutine(RecordFrame());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
