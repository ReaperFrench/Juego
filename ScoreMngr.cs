//Nombre del desarrollador: Gabriel Vives
//Asignatura: Estructura de Datos
//Descripcion del uso de este codigo: Este codigo sirve para mostrar el conteo de la puntuacion
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreMngr : MonoBehaviour
{
        
         private TextMeshProUGUI TextScore; //se llama al texto a cambiar
        private int Score; //la cantidad que se contara
   // Start is called before the first frame update
    void Start()
    {
        //se llama al componente del texto que queremos actualizar
          TextScore = gameObject.GetComponent<TextMeshProUGUI>();
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //este sera el parametro que se utilizara dentro del script del enemigo al momento de ser eliminado se actualizara
     public void ActualizarScore()
    {
        Score +=100;
        TextScore.text = Score.ToString();
        Debug.Log("El Score es de"+Score);
    }
}
