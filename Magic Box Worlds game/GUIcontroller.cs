using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUIcontroller : MonoBehaviour {
    public Image GUIimage;
    public Text GUItext;
    public Image GUIback;

    public static GUIcontroller Instance { get; private set; }
    void Awake ()
    {
        Instance = this;
        GUIimage.enabled = false;
        GUItext.enabled = false;
        GUIback.enabled = false;

    }

    public void high (Sprite newimage, Sprite newback, string text)
    {
        Debug.Log("Hi!");
        GUIimage.sprite = newimage;
        GUIimage.enabled = (newimage != null);
        GUIback.sprite = newback;
        GUIback.enabled = (newback != null);
        GUItext.enabled = true;
        GUItext.text = text;
    }
	
	
	
}
