//Nombre del desarrollador: Gabriel Vives
//Asignatura: Estructura de Datos
//Descripcion del uso de este codigo: Este codigo sirve para ponerle los parametros a nuestra bala
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    // Start is called before the first frame update
    //nos indica que al omomento de colisionar con objetos con ciertos tags, destruira a la bala, esto se hace para no generar basura informatica inecesaria.
void OnCollisionEnter2D(Collision2D collision)
{
     if(collision.gameObject.tag=="Objeto")
    {
        Destroy(this.gameObject);
    }
    else
    {
        if(collision.gameObject.tag=="Enemy")
        {
            Destroy(this.gameObject);
        }
    }

}
    
}

