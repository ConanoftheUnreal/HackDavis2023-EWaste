using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class PCImage3Story : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private TextMeshProUGUI mText;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        this.mText.text = "If reusing is not possible, take the device to a recycling center. The device will be shredded, toxic metals will be disposed of responsibly, and reusable parts will be used to make a new computer.";
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        //backgroundImage.GetComponent<Image>().sprite = this.imageOff;
        this.mText.text = "Put your mouse over an image to view.";
    }
}