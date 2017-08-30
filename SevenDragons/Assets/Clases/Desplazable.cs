using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Desplazable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public Transform parentToReturnTo = null;

	public void OnBeginDrag (PointerEventData eventData) {
		//Debug.Log ("OnBeginDrag");

		parentToReturnTo = this.transform.parent;   
		this.transform.SetParent (this.transform.parent.parent); 

		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}

	public void OnDrag (PointerEventData eventData) {

		Vector3 posicionMouse = Input.mousePosition;	//Optiene la posición del mouse
		posicionMouse.z = -2f;							//Cambia la ubicación en z

		this.transform.position = Camera.main.ScreenToWorldPoint (posicionMouse); //actualiza la posición del objeto según la ubicación del mouse
		//this.transform.SetParent ()

		//Buscar las zonas permitidas dependiendo del objeto
		//DropZone zones = GameObject.FindObjectOfType<DropZone> ();

	}

	public void OnEndDrag (PointerEventData eventData) {

		Vector3 posicionMouse = Input.mousePosition;
		posicionMouse.z = 0f;

		this.transform.position = Camera.main.ScreenToWorldPoint (posicionMouse);

		this.transform.SetParent (parentToReturnTo);
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
	}

}
