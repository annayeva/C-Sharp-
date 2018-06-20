using UnityEngine;
using UnityEngine.EventSystems;


[RequireComponent(typeof(BoxCollider))]
public class ClickOnBox : MonoBehaviour, IPointerClickHandler {

    private Animator thisAnimator;
    private BoxCollider thisBoxCollider;
    void Awake()
    {
        thisAnimator = GetComponent<Animator>();
        thisBoxCollider = GetComponent<BoxCollider>();
    }

    public void OnPointerClick(PointerEventData eventData)

    {
        if (thisAnimator != null)
        { 
            thisAnimator.SetBool("Click on box", true);
            Debug.Log("Hi!");
            thisBoxCollider.enabled = false;
        }
        else
        {
            Debug.Log("Doesn`t have an Animator.");
        }
    }

	
	
}
