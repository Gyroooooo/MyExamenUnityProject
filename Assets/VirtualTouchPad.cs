using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class VirtualTouchPad : MonoBehaviour, IDragHandler,IEndDragHandler
{

    public Vector2 pixel_delta;

    public void OnDrag(PointerEventData eventData) // процес свайпа
    {
        pixel_delta = eventData.delta;
        
    }

    public void OnEndDrag(PointerEventData eventData)// коли свайп закінчився
    {
        
        pixel_delta = Vector2.zero;
        
    }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
