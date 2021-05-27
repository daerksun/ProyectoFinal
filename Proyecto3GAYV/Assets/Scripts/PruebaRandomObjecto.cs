using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaRandomObjecto : MonoBehaviour
{
    public GameObject ObjetoPrueba;
    //private int valRandom3; //Valor que escoge del objeto de la lista //2 objetos p/tipo de basura //Prueba ******
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject[] BasuraOr; //Basura Orgánica
    public GameObject[] BasuraIn; //Basura Inorgánica
    public GameObject[] BasuraRP; //Residuos peligrosos
    public GameObject[] Bomba; //Bomba
    
    public float TiempoCreacion = 1.0f, RangoCreacion = 2.0f;
    //public ObjectMovement objectMovement;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("Creando",0.0f,TiempoCreacion);
    }

    // Update is called once per frame
    void Update()
    {
       //valRandom3 = Random.Range(0,3);
    }

    public void Creando()
    {
        Vector3 SpawnPosition = new Vector3 (0,0,0);
        SpawnPosition = this.transform.position;
        float valRandom = Random.Range(-6.45f,6.45f); //Valores que delimitan la caída de objeto sobre el eje X
        int valRandom2 = Random.Range(0,4); //Valor que escoge la lista de donde se va a tomar el objeto aleatorio
        int valRandom3 = Random.Range(0,4); //Valor que escoge del objeto de la lista //4 objetos p/tipo de basura
        //int valRandom3 = Random.Range(0,1); //Valor que escoge del objeto de la lista //2 objetos p/tipo de basura //Prueba ******
        SpawnPosition = new Vector3 (SpawnPosition.x + valRandom,SpawnPosition.y,SpawnPosition.z);
        switch(valRandom2)
        {
            case 0: A= Instantiate (BasuraOr[valRandom3], SpawnPosition, Quaternion.identity);
                A.name = "Organica";
                A.AddComponent<ObjectMovement>();
                A.AddComponent<CollisionObject>();
                A.name = "Organica";
                break;
            case 1: B= Instantiate (BasuraIn[valRandom3], SpawnPosition, Quaternion.identity);
                B.name = "Inorganica";
                B.AddComponent<ObjectMovement>();
                B.AddComponent<CollisionObject>();
                B.name = "Inorganica";
                break;
            case 2: C= Instantiate (BasuraRP[valRandom3], SpawnPosition, Quaternion.identity);
                //objectMovement.enabled = false;
                C.name = "ResPeligroso";
                C.AddComponent<ObjectMovement>();
                C.AddComponent<CollisionObject>();
                C.name = "ResPeligroso";
                break;
            case 3: D= Instantiate (Bomba[valRandom3], SpawnPosition, Quaternion.identity);
                //objectMovement.enabled = false;
                D.name = "Bomba";
                D.AddComponent<ObjectMovement>();
                D.AddComponent<CollisionObject>();
                D.name = "Bomba";
                break;
            default:
                break;
        }
        //SpawnPosition = new Vector3 (SpawnPosition.x + valRandom,SpawnPosition.y,SpawnPosition.z);

        //ObjetoPrueba = Instantiate (ObjetoPrueba, SpawnPosition, Quaternion.identity);
    }
}