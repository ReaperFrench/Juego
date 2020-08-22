//Nombre del desarrollador: Gabriel Vives
//Asignatura: Estructura de Datos
//Descripcion del uso de este codigo: Este codigo nos sirve para realizar el disparo de nuestro jugador
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform DisparoInicio;//El punto inicial desde donde se generara nuestra bala
    public GameObject BalaPrefab;//lugar donde se pondra el prefab de nuestra bala
    public float FuerzaDisparo = 10f;//velocidad de disparo.


    // Update is called once per frame
    void Update()
    {//lugar donde al presionar cierto boton se generar el disparo
        if(Input.GetMouseButton(0))
        {
            Disparo();
        }
    }
    //En este void es desde donde se instancia nuestro prefab de la bala y como saldra disparada.
    void Disparo()
    {
        GameObject Bala = Instantiate(BalaPrefab, DisparoInicio.position,DisparoInicio.rotation);
        Rigidbody2D rb =  Bala.GetComponent<Rigidbody2D>();
        rb.AddForce(DisparoInicio.up*FuerzaDisparo,ForceMode2D.Impulse);
    }   
}
