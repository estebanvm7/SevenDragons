using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdministradorInicioDeJuego : MonoBehaviour {

	public void nuevoJuego(string nombre){

		SceneManager.LoadScene (nombre);

	}
}
