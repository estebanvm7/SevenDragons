using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Validacion {

	public bool verificarMovimiento(Carta c, int fila, int columna){

		Juego temp = Juego.obtenerInstanciaJuego ();

		//si existe una carta en la posición especifica -> false
		if (temp.obtenerCartaDelAreaDeJuego(fila,columna) != null) {
			Debug.Log ("False: ya existe carta en la posición especificada");
			return false;
		}

		//obtiene las cartas adyacentes
		Carta izquierda = temp.obtenerCartaDelAreaDeJuego(fila, columna - 1);
		Carta derecha = temp.obtenerCartaDelAreaDeJuego(fila, columna + 1);
		Carta arriba = temp.obtenerCartaDelAreaDeJuego(fila -1, columna);
		Carta abajo = temp.obtenerCartaDelAreaDeJuego(fila + 1, columna);

		//si todos los espacios adyacentes son null (no existe carta adyacente) -> false
		if (izquierda == null && derecha == null && arriba == null && abajo == null) {
			Debug.Log ("False: no hay carta adyacente");
			return false;
		}

		//si la validación de las cartas adyacentes es correcta -> bool
		if (validarIzquierda(c, izquierda) && validarDerecha(c, derecha)
			&& validarArriba(c, arriba) && validarAbajo(c, abajo)) {
			Debug.Log ("True: validación de cartas adyacentes");
			return true;
		} else {
			Debug.Log ("False: validación de cartas adyacentes");
			return false;
		}
		//return false;
	}

	private bool validarIzquierda(Carta c, Carta cIzquierda){
		if (cIzquierda == null) { //no hay carta a la izquierda
			return true;

		} else { //existe una carta a la izquierda

			//obtiene los colores de la carta a verificar
			int [,] carta = c.getColores();
			//obtiene los colores de la carta de la izquierda
			int [,] izquierda = cIzquierda.getColores();

			//valor de la matriz de colores
			int cArribaIzquierda;
			int cAbajoIzquierda;
			int ctempArribaDerecha;
			int ctempAbajoDerecha;

			//si la carta es invertida realiza la conversión necesaria
			if (c.esInvertida()) {
				cArribaIzquierda = carta[1,1];
				cAbajoIzquierda = carta [0,1];
			} else {
				cArribaIzquierda = carta[0,0];
				cAbajoIzquierda = carta [1,0];
			}

			//si la carta de la izquierda es invertida realiza la conversión necesaria
			if (cIzquierda.esInvertida()) {
				ctempArribaDerecha = izquierda[1,0];
				ctempAbajoDerecha = izquierda[0,0];
			} else {
				ctempArribaDerecha = izquierda[0,1];
				ctempAbajoDerecha = izquierda[1,1];
			}

			//si la carta es principal -> true
			if (cArribaIzquierda == 6){
				return true;
			}

			//si la carta  adyacente es inicial (6) o carta colores (7)
			else if (ctempArribaDerecha == 6 || ctempArribaDerecha == 7 ) {
				return true;
			}

			//si tiene adyacencia igual
			else if (ctempArribaDerecha == cArribaIzquierda || ctempAbajoDerecha == cAbajoIzquierda ) {
				return true;

			} else {
				//Adyacencia diferente
				return false;
			}
			//Adyacencia diferente
			//return false;
		}
		//return false;

	}

	private bool validarDerecha(Carta c, Carta cDerecha){
		if (cDerecha == null) { //no hay carta a la derecha
			return true;

		} else { //existe una carta a la derecha

			int [,] carta = c.getColores();
			int [,] derecha = cDerecha.getColores();

			int cArribaDerecha;
			int cAbajoDerecha;
			int ctempArribaIzquierda;
			int ctempAbajoIzquierda;

			if (c.esInvertida()) {
				cArribaDerecha = carta[1,0];
				cAbajoDerecha = carta [0,0];
			} else {
				cArribaDerecha = carta[0,1];
				cAbajoDerecha = carta [1,1];
			}

			if (cDerecha.esInvertida()) {
				ctempArribaIzquierda = derecha[1,1];
				ctempAbajoIzquierda = derecha[0,1];
			} else {
				ctempArribaIzquierda = derecha[0,0];
				ctempAbajoIzquierda = derecha[1,0];
			}

			//si la carta es especial (colores)
			if (cArribaDerecha == 6){
				return true;
			}

			//si la carta  adyacente es especial
			else if (ctempArribaIzquierda == 6 || ctempArribaIzquierda == 7) {
				return true;
			}

			//si tiene adyacencia igual
			else if (cArribaDerecha == ctempArribaIzquierda || cAbajoDerecha == ctempAbajoIzquierda) {
				return true;

			} else {
				//no hay adyacencia
				return false;

			}
			//Adyacencia diferente
			//return false;
		}
		//return false;
	}

	private bool validarArriba(Carta c, Carta cArriba){
		if (cArriba == null) { //no hay carta arriba
			return true;

		} else { //existe una carta arriba

			int [,] carta = c.getColores();
			int [,] arriba = cArriba.getColores();

			int cArribaIzquierda;
			int cArribaDerecha;
			int ctempAbajoIzquierda;
			int ctempAbajoDerecha;

			if (c.esInvertida()) {
				cArribaIzquierda = carta[1,1];
				cArribaDerecha = carta [1,0];
			} else {
				cArribaIzquierda = carta[0,0];
				cArribaDerecha = carta [0,1];
			}

			if (cArriba.esInvertida()) {
				ctempAbajoIzquierda = arriba[0,1];
				ctempAbajoDerecha = arriba[0,0];
			} else {
				ctempAbajoIzquierda = arriba[1,0];
				ctempAbajoDerecha = arriba[1,1];
			}

			//si la carta es especial (colores)
			if (cArribaIzquierda == 6){
				return true;
			}

			//si la carta  adyacente es especial
			else if (ctempAbajoIzquierda == 6 || ctempAbajoIzquierda == 7) {
				return true;
			}

			//si tiene adyacencia igual
			else if ( ctempAbajoIzquierda == cArribaIzquierda  || ctempAbajoDerecha == cArribaDerecha ) {
				return true;

			} else {
				//no hay adyacencia
				return false;
			}
			//Adyacencia diferente
			//return false;
		}
		//return false;
	}

	private bool validarAbajo(Carta c, Carta cAbajo){
		if (cAbajo == null) { //no hay carta abajo
			return true;

		} else { //existe una carta abajo

			int [,] carta = c.getColores();
			int [,] abajo = cAbajo.getColores();

			int cAbajoIzquierda;
			int cAbajoDerecha;
			int ctempArribaIzquierda;
			int ctempArribaDerecha;

			if (c.esInvertida()) {
				cAbajoIzquierda = carta[0,1];
				cAbajoDerecha = carta [0,0];
			} else {
				cAbajoIzquierda = carta[1,0];
				cAbajoDerecha = carta [1,1];
			}

			if (cAbajo.esInvertida()) {
				ctempArribaIzquierda = abajo[1,1];
				ctempArribaDerecha = abajo[1,0];
			} else {
				ctempArribaIzquierda = abajo[0,0];
				ctempArribaDerecha = abajo[0,1];
			}

			//si la carta es especial
			if (cAbajoIzquierda == 6){
				return true;
			}

			//si la carta  adyacente es especial
			else if (ctempArribaIzquierda == 6 || ctempArribaIzquierda == 7) {
				return true;
			}

			//si tiene adyacencia igual
			else if ( cAbajoIzquierda == ctempArribaIzquierda || cAbajoDerecha == ctempArribaDerecha ) {
				return true;

			} else {
				//no hay adyacencia
				return false;
			}
			//Adyacencia diferente
			//return false;
		}
		//return false;
	}
}