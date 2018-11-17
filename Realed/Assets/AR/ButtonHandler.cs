using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using Image = Vuforia.Image;

public class ButtonHandler : MonoBehaviour {

    private Image.PIXEL_FORMAT _pixel_format = Image.PIXEL_FORMAT.UNKNOWN_FORMAT;
    public Button ScreenShotButton;

    void Start ()
    {
        Debug.Log("Button handler");
        var btn = ScreenShotButton.GetComponent<Button>();
        btn.onClick.AddListener(CompareFaces);
    }

    public void CompareFaces()
    {
        Debug.Log("Compare faces");
        var image = CameraDevice.Instance.GetCameraImage(_pixel_format);
        if (image != null)
        {
            byte[] pixels = image.Pixels;
            Debug.Log(pixels.Length);
            //TODO: Call service
        }
    }

}
