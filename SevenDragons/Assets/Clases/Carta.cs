using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour {

	private int[,] colores;// = new int[2, 2];
	private bool[] adjacencia;// = new bool[4];
	private bool invertida;// = false;

	public Carta () {
		this.colores = new int[2,2];
		adjacencia = new bool[4];
		invertida = false;
	}

	public Carta(int[,] colores) {
		this.colores = colores;
		this.adjacencia = new bool[4];
		this.invertida = false;
	}
		
	public bool esInvertida() {
		return this.invertida;
	}

	public void activarInvertida() {
		this.invertida = true;
	}

	public void desactivarInvertida() {
		this.invertida = false;
	}

	public void setAdjecencia(bool[] adj) {
		if (adj.Length == 4) {
			this.adjacencia = adj;
		} else {
			Debug.Log ("Carta - setAdjacencia - Error: arreglo de tamaño diferete a 4");
		}

	}

	public bool[] getAdjacencia() {
		return this.adjacencia;
	}

	public int[,] getColores() {
		return this.colores;
	}

}
