using UnityEngine;
using System.Collections;

public class SoundTextTrigger : MonoBehaviour {

    public AudioClip wordSound;
    public Sprite image;
    public Sprite back;
    public string text;

    void OnTriggerEnter (Collider COL)
    {
        if (COL.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(wordSound, transform.position);
            GUIcontroller.Instance.high(image, back, text);
        }
    }

    void OnTriggerExit (Collider COL)
    {
        GUIcontroller.Instance.high(null, null, "");
    }
}
