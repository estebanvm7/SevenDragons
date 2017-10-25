using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour, IPointerClickHandler {

	public void OnPointerClick(PointerEventData eventData){

		GameObject go = eventData.pointerPress;

		if (eventData.button == PointerEventData.InputButton.Right) {

			float rotacionZ = go.transform.rotation.x;
			rotacionZ += 180 % 360;
			go.transform.Rotate (0, 0, rotacionZ);

			//cambiar valor de invertido de la carta rotada
			go.GetComponent<Desplazable> ().getCarta ().modificarInvertida ();

		}
	}

}
