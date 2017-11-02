using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IPointerEnterHandler, IDropHandler, IPointerExitHandler {

	public void OnPointerEnter (PointerEventData eventData) {

	}

	public void OnPointerExit (PointerEventData eventData) {

	}

	public void OnDrop (PointerEventData eventData) {
		Debug.Log (eventData.pointerDrag.name + " was dropped on " + gameObject.name);

		//obtener x, y del panel
		GameObject panel = gameObject;
		Panel p = panel.GetComponent<Panel> ();
		int fila = p.getX ();
		int columna = p.getY ();

		//obtener valores de la carta
		GameObject carta = eventData.pointerDrag;
		Carta c = carta.GetComponent<Desplazable> ().getCarta ();

		//si el movimiento es valido
		if (Juego.obtenerInstanciaJuego ().verificarMovimiento (c, fila, columna)) {
			Desplazable d = eventData.pointerDrag.GetComponent<Desplazable> ();
			if (d != null) {
				d.parentToReturnTo = this.transform;
			}

			//agrega la carta a la lógica
			Juego.obtenerInstanciaJuego ().agregarCartaAlAreaDeJuego (c, fila, columna);

			//PENDIENTE
			//agregar la carta a la vista Area de juego

		} else {
			Debug.Log ("OnDrop: validación fallida");
		}


	}
}
