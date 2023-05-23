using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.EventSystems;
using Answers;

public class DragAndDrop : MonoBehaviour, /*IPointerDownHandler,*/ IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTrans;
    [SerializeField] private Canvas myCanvas;
    private CanvasGroup canvasGroup;
    public int id;
    [SerializeField] public TYPES group;

    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    { 
        var x = Instantiate(eventData.pointerDrag.gameObject);
        x.transform.SetParent(myCanvas.transform, false);
        //x.transform.parent = myCanvas.transform;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTrans.anchoredPosition += eventData.delta / myCanvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
    }

    /*public void OnPointerDown(PointerEventData eventData)
    {

    }*/
}
