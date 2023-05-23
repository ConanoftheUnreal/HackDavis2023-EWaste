using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class PImage1Story : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private TextMeshProUGUI mText;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        this.mText.text = "Ink cartridges in printers often have their own form of recycling. Left over ink is recycled to create recycled ink, and the cartridges are bought back by companies and resold with new ink.";
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        //backgroundImage.GetComponent<Image>().sprite = this.imageOff;
        this.mText.text = "Put your mouse over an image to view.";
    }
}