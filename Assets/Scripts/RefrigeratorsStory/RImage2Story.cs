using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class RImage2Story : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private TextMeshProUGUI mText;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        this.mText.text = "Suspected of containing PCBs (Polychlorinated biphenyl), capacitors are registered as a hazardous waste incinerator and are also removed from the refrigerator to be destroyed.";
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        //backgroundImage.GetComponent<Image>().sprite = this.imageOff;
        this.mText.text = "Put your mouse over an image to view.";
    }
}