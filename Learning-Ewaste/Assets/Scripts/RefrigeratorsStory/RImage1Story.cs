using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class RImage1Story : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private TextMeshProUGUI mText;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        this.mText.text = "Refrigerators contain a lot of non-reusable items such as foam, plastic,and gasses due to the cooling process. Freon, is a liquid/gaseous fluorocarbon, that’s used as a refrigerant and is removed with the oil from the compressor.";
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        //backgroundImage.GetComponent<Image>().sprite = this.imageOff;
        this.mText.text = "Put your mouse over an image to view.";
    }
}