using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta {

	private int[,] colores;// = new int[2, 2];
	private bool[] adjacencia;// = new bool[4];
	private bool invertida;// = false;
	private bool especial;// = false

	private Carta () {
		this.colores = new int[2,2];
		adjacencia = new bool[4];
		invertida = false;
		especial = false;
	}

	public Carta(int[,] colores) {
		this.colores = colores;
		this.adjacencia = new bool[4];
		this.invertida = false;
		this.especial = false;

//		bool[] adjacencia = new bool[4];
//
//		Carta (colores, adjacencia, false, false);
	}

	public Carta(int[,] colores, bool invertida) {
		
		this.invertida = invertida;
		this.colores = colores;
		this.adjacencia = new bool[4];
		this.especial = false;

//		bool[] adjacencia = new bool[4];
//
//		Carta (colores, invertida, adjacencia, false);


	}

	public Carta(int[,] colores, bool invertida, bool [] adjacencia, bool especial) {

		this.colores = colores;
		this.invertida = invertida;
		this.adjacencia = adjacencia;
		this.especial = especial;


	}

	public Carta(int color, bool especial) {

		//crea la matriz de colores
		int [,] colores = {{color,color},{color,color}};

//		Carta (colores); //llama el contructor regular

		this.especial = true;

		this.colores = colores;
		this.adjacencia = new bool[4];
		this.invertida = false;

	}
		
	public bool esInvertida() {
		return this.invertida;
	}

	public void modificarInvertida(){
		if (invertida) {
			this.invertida = false;
		} else {
			this.invertida = true;
		}
	}

//	public void activarInvertida() {
//		this.invertida = true;
//	}
//
//	public void desactivarInvertida() {
//		this.invertida = false;
//	}

	public void setAdjecencia(bool[] adj) {
		if (adj.Length == 4) {
			this.adjacencia = adj;
		} else {
			//Debug.Log ("Carta - setAdjacencia - Error: arreglo de tamaño diferete a 4");
		}

	}

	public bool[] getAdjacencia() {
		return this.adjacencia;
	}

	public int[,] getColores() {
		return this.colores;
	}

	public bool esEspecial(){
		return this.especial;
	}

	protected void setEspecial(bool especial) {
		this.especial = especial;
	}

}
