using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


//이 클릭&드래그 인터페이스는
//Canvas안에 있는 UI요소만 적용된다.
//마우스를 때면 무조건  
public class Test23 : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler //드래그 중일 때 그 객체에서 마우스가 벗어나지 않은 상태에서 클릭을 때면(조건이 존재_
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        Debug.Log("Drag");
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drop");
    }
}
