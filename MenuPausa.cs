//Nombre del desarrollador: Gabriel Vives
//Asignatura: Estructura de Datos
//Descripcion del uso de este codigo: Este codgi sirve para que al momento de presionar una tecla designada el juego se pause.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPausa : MonoBehaviour
{
 public static bool Pause = false; //hace que el panel este desactivado desde inicio
  public GameObject menuPausa; //lugar en el cual colocaremos a nuestro panel

    // Update is called once per frame
    void Update()
    {
        //al momento de presionar la tecla designada ejecutara los ciclos en pantalla
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Pause)
            {
                Resume();
            }
            else
             {
                 MPause();
             }
        }
    }
    // void el cual nos genera el resumir el juego al momento de presionar el boton
    public void Resume()
    {
        menuPausa.SetActive(false);
        Time.timeScale = 1f;
        Pause = false;
    }
    //Al momento de presionar el boton se ejecutaran este proceso, de esta menera se detendra el juego.
    public void MPause()
    {
        menuPausa.SetActive(true);
        Time.timeScale = 0f;
        Pause = true;
    }
    //Al momento de hacer clic en el boton designado se regresara al menu principal
    public void CargarMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    //al momento de hacer clic en el boton designado se cerrara el juego.
    public void Quit()
    {
        Application.Quit();
    }
}
