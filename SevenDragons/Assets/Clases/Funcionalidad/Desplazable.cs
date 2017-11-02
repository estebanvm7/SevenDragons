using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Desplazable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public Transform parentToReturnTo = null;
	private Carta carta;

	public void setCarta(Carta laCarta) {
		this.carta = laCarta;
	}

	public Carta getCarta(){
		return this.carta;
	}

	public void OnBeginDrag (PointerEventData eventData) {

		parentToReturnTo = this.transform.parent;

		//asigna vistaJuega como padre temporal mientras se mueve la carta 
		GameObject temp = GameObject.FindGameObjectWithTag ("VistaJuego");
		this.transform.SetParent (temp.transform);

		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}

	public void OnDrag (PointerEventData eventData) {

		//Optiene la posición del mouse
		Vector3 posicionMouse = Input.mousePosition;

		//Cambia la ubicación en z
		posicionMouse.z = -2f;							

		//actualiza la posición del objeto según la ubicación del mouse
		this.transform.position = Camera.main.ScreenToWorldPoint (posicionMouse); 
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
