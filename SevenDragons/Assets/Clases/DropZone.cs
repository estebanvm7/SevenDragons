using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour,IPointerEnterHandler, IDropHandler, IPointerExitHandler {

	public void OnPointerEnter (PointerEventData eventData) {


	}

	public void OnPointerExit (PointerEventData eventData) {

	}


	public void OnDrop (PointerEventData eventData) {
		Debug.Log (eventData.pointerDrag.name + " was dropped on " + gameObject.name);

		Desplazable d = eventData.pointerDrag.GetComponent<Desplazable>();
		if(d != null) {
			d.parentToReturnTo = this.transform;
		}
	}
}
