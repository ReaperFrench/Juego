//Nombre del desarrollador: Gabriel Vives
//Asignatura: Estructura de Datos
//Descripcion del uso de este codigo: Este codigo sirve para mostrar en pantalla las vidas, al igual que controlar todos los objetos del UI
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIMngr : MonoBehaviour
{
   public Sprite[] CantidadVidas;//array el cual desplega las vidas
    public Image imagenCantidadVidas;//lugar en donde se pondran las imagenes de nuestras vidas
    
    //Actualiza al momento de recibir daño
    public void ActualizarVidas(int vidas)
    {
        Debug.Log("El jugador tiene" + vidas);
        imagenCantidadVidas.sprite = CantidadVidas[vidas];
    }
    public void ActualizarScore()
    {

    }
}
