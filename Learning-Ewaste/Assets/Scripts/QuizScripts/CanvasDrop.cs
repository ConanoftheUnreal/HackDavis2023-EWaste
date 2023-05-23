using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CanvasDrop : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Item Dropped");
        if (eventData.pointerDrag != null)
        {
            Destroy(eventData.pointerDrag.gameObject);
        }
    }
}
