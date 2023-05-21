using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class PImage2Story : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private TextMeshProUGUI mText;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        this.mText.text = "If a printer can be repaired, repairing and reusing is best for the environment. In the case that this is not possible, the device will be shredded, and reusable parts will be harvested to be given new life.";
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        //backgroundImage.GetComponent<Image>().sprite = this.imageOff;
        this.mText.text = "Put your mouse over an image to view.";
    }
}