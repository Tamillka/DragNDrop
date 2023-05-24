using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
    //uzglabas noradi uz Objekti skriptu
    public Objekti objektuSkripts;
    //Uzglabas noradi uz katra objekta CanvaGroup
    private CanvasGroup kanvasGrupa;
    private RectTransform velkObjRectTrans;
    public void OnBeginDrag(PointerEventData eventData) {
       
    }

    public void OnDrag(PointerEventData eventData)  {
       
    }

    public void OnEndDrag(PointerEventData eventData)  {

    }


    void Start () {
		kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjRectTrans = GetComponent<RectTransform>();
	}
	
	
	
}
