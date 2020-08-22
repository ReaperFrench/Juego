//Nombre del desarrollador: Gabriel Vives
//Asignatura: Estructura de Datos
//Descripcion del uso de este codigo: Este codgio sirve para el funcionamiento de los botones dentro del gameover
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOVer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //este ara que el boton reinicie el nivel
     public void Retry()
    {
            SceneManager.LoadScene(1);
    }
    //esto ara que el boton se salga a nuestro menu principal.
    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
