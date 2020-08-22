//Nombre del desarrollador: Gabriel Vives
//Asignatura: Estructura de Datos
//Descripcion del uso de este codigo: Este codigo nos sirve para la movilidad de nuestro jugador
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public static bool GO = false; //Este nos generar la pantalla de GameOver
    public GameObject GameOver;//Lugar donde pondremos nuestro panel de gameover
    private UIMngr UiManager; //paramaetro que llama al codigo del UImngr
    public int Jugadorvida = 3;//la vida de nuestro jugador
    public float MovSpd = 5f;//velocidad de nuestro jugador
    public Rigidbody2D rb;//parametro de rigid body de nuestro jugador
    public Camera cam; //parametro de la camara
    Vector2 movimiento; //direccion en la cual se movera nuestro jugador
    Vector2 MousePos;//la posicion del mouse
   public Animator animator; 
   

    // Start is called before the first frame update
    void Start() 
    {
        //aqui llamaremos las animacion del jugador, al igual que localizar los componentes del UImngr para poder actualizar las vidas.
        animator = GetComponent<Animator>();
        UiManager = GameObject.Find("UIMngr").GetComponent<UIMngr>();
            if (UiManager != null)
        {
            
            UiManager.ActualizarVidas(Jugadorvida);
        }
    }

    // Update is called once per frame
    void Update()
    {
      //se declaran las direcciones en las cuales el jugador se movera junto con sus animaciones, al igual que la posicion del mouse.
        movimiento.x = Input.GetAxis("Horizontal");
        movimiento.y = Input.GetAxis("Vertical");
       animator.SetFloat("Strafe", movimiento.x);
       animator.SetFloat("Forward", movimiento.y);

       MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        //aqui se utilizan las variablees declaradas para poder realizar el movimiento del jugador, como tambien que el sprite del jugador mire a nuestro mouse.
        rb.MovePosition(rb.position + movimiento * MovSpd * Time.fixedDeltaTime);

        Vector2 lookDir = MousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;

    }
    //aqui se denotara el daño que se le realizar al jugador, restandole vidas y actualizandolo en pantalla
     public void Damage()
        {
            Jugadorvida--;
            UiManager.ActualizarVidas(Jugadorvida);
            if(Jugadorvida<=0)
            {
                //Instantiate(MuerteJugadorPrefab, transform.position, Quaternion.identity);
                Destroy(this.gameObject);
                GameOvr();
                //GameOver();

            }
        }
        //Al momento de que el jugador muere se desplegara esta pantalla.
         public void GameOvr()
        {
            GameOver.SetActive(true);
                GO = true;
        }
}
