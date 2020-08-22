//Nombre del desarrollador: Gabriel Vives
//Asignatura: Estructura de Datos
//Descripcion del uso de este codigo: Este codigo sirve para darle movimiento a nuestro enemigo junto con sus funciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float VelMov = 1.0f; // esta es la velocidad de nuestro enemigo
    private Rigidbody2D rb; // se manda a llamar al componente rigidbody
    private Transform player; //Se manda a llamar al los parametros de Escala, Posision y Rotacion del Objeto
    private Vector2 movimiento;  //se delcara la direccion como un vector, indicando hacia donde se movera el enemigo
    private SpriteRenderer sr; //se le llama a las opciones del spriteRednerer
    public bool facingRight = false; //variable para comprovar en que direccion esta viendo el enemigo
    private ScoreMngr UIScore; // Variable la cual llama directamente del Script ScoreMngr y sus componentes
    public int VidaEnemigo = 100; // la vida del enemigo
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); //Encuentra el componente de transform del jugador
        /*rb = this.GetComponent<Rigidbody2D>(); */
        sr = this.GetComponent<SpriteRenderer>(); //busca el componente del spriteRenderer
        UIScore = GameObject.Find("CantidadScore").GetComponent<ScoreMngr>();//Encuentra el parametro localizado dentro de ScoreMngr
        
    }

    // Update is called once per frame
    void Update()
    {
        //Este procedimiento nos sirve para realizar que el enemigo se mueva hacia el jugador como tambien al momento de estar en ciertos lugares del plano cartesiano
        //se flipe el sprite del enemigo
        transform.position = Vector2.MoveTowards(transform.position, player.position, VelMov * Time.deltaTime);
        if (player.transform.position.x < gameObject.transform.position.x && facingRight)
            Flip ();
        if (player.transform.position.x > gameObject.transform.position.x && !facingRight)
            Flip ();
    }
    //eeste es el void utilizado para realizar la accion del flipeo como tal
    void Flip ()
    {
        facingRight = !facingRight;
        Vector3 tmpScale = gameObject.transform.localScale;
        tmpScale.x *= -1;
        gameObject.transform.localScale = tmpScale; 
    }
    //Este nos indica que al momento de colisionar con un objeto con la denominacion de su tag, se le restara vida al enemigo, destruyendolo junto con la bala
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "Bola")
         {
            VidaEnemigo--;
            if(VidaEnemigo <=0)
            {
                Destroy(other.gameObject);
                     UIScore.ActualizarScore();
                     Destroy(this.gameObject);
            }
         }
          
        //Este nos indica que al momento de colisionar con el jugador, este le restara vida al jugador y se destruira
        if (other.tag == "Player")
        {
            PlayerMov P1 = other.GetComponent<PlayerMov>();
            if (P1!=null)   
            {
                P1.Damage();
                
            }
            Destroy(this.gameObject);
        }
        
        
        
        
    }
        /*Vector3 direccion = player.position - transform.position;
        float angle = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
        direccion.Normalize();
        movimiento = direccion;
         if (direccion = player.position - transform.position)
        {
            if ( sr.flipX == false)
            {
                sr.flipX = true;
            }
            
            
        }*/
    }
    /*private void FixedUpdate() 
    {
          /* PersonajeMov(movimiento);*/
           
      
    
   /* void PersonajeMov(Vector2 direccion)
    {
        rb.MovePosition((Vector2)transform.position + (direccion * VelMov * Time.deltaTime));
       
    } */

