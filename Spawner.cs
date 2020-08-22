//Nombre del desarrollador: Gabriel Vives
//Asignatura: Estructura de Datos
//Descripcion del uso de este codigo: Este codigo sirve para controlar las oleadas de los enemigos
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static int ContadorEnemigos; // cuenta la cantidad de enemigos en pantalla
    public GameObject ObjEnemigo;//Lugar en donde se localizara nuestro objeto, en este caso el prefab del enemigo
    public Transform[] SpawnPoint;//Array el cual localiza las posiciones de los spawner
   
    public int TopeEnemigos;//nos delimita la cantidad de enemigos
   
    // Start is called before the first frame update
    void Start()
    {
        //esto genera que automaticamente se asignen los spawn points a nuestro array y empieza a generar las oleadas cada 2 segundos
     ContadorEnemigos = 0;
        
            SpawnPoint = new Transform[transform.childCount];
        for (int i = 0; i < SpawnPoint.Length; i++)
        {
            SpawnPoint[i] = transform.GetChild(i);
        }   
        InvokeRepeating("Spawn", 2f, 1f);  
        
       


    }

    // Update is called once per frame
    void Update()
    {
       
    }
    //Este es nuestro spawner como tal, el cual genera los enemigos.
    void Spawn()
    {
         foreach (var p in SpawnPoint)
            {
                 GameObject EnemigoPos = Instantiate(ObjEnemigo) as GameObject;
                 EnemigoPos.transform.position = p.position;
                 //Destroy(this.gameObject);
            }
    }

}
