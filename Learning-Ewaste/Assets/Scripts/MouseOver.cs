using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Sprite imageOn;
    [SerializeField] private Sprite imageOff;
    [SerializeField] private GameObject backgroundImage;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        backgroundImage.GetComponent<Image>().sprite = this.imageOn;
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        backgroundImage.GetComponent<Image>().sprite = this.imageOff;
    }
}
