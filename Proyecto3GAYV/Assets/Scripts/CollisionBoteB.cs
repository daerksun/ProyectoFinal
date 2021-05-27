using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBoteB : MonoBehaviour
{
    public GameOver GameOver;
    public GameObject[] corazones;
    public int vida;
    public int puntaje;
    public int y;
    public int x;
    public int ClaveNivel; //  1 --> Basura Orgánica  /  2 --> Basura Inorgánica  /  3 --> Residuos Peligrosos
    // Start is called before the first frame update
    void Start()
    {
        vida = corazones.Length - x;
    }

    // Update is called once per frame
    void Update()
    {
        if(vida<1)
        {
            Destroy(corazones[1].gameObject);
            //gameOver.checarVida();
        }
        else if(vida<2)
        {
            Destroy(corazones[2].gameObject);
        }
        else if(vida<3)
        {
            Destroy(corazones[3].gameObject);
        }
    }

    void OnCollisionEnter(Collision obj)
    { 
        if(obj.gameObject.name == "Bomba")
        {
            vida = 0;
            Destroy(corazones[1].gameObject);
            Destroy(corazones[2].gameObject);
            Destroy(corazones[3].gameObject);
            GameOver.checarVida();
        }
       if( ClaveNivel == 1)// Basura Orgánica
       {
           if(obj.gameObject.name != "Organica")
            {
                vida = vida-1;
            }
            else if(obj.gameObject.name == "Organica")
            {
                puntaje = puntaje + 1;
            }
       }
       else if( ClaveNivel == 2)// Basura Inorgánica
       {
           if(obj.gameObject.name != "Inorganica")
            {
                vida = vida-1;
            }
            else if(obj.gameObject.name == "Inorganica")
            {
                puntaje = puntaje + 1;
            }
       }
       else if( ClaveNivel == 3)// Residuos Peligrosos
       {
           if(obj.gameObject.name != "ResPeligroso")
            {
                vida = vida-1;
            }
            else if(obj.gameObject.name == "ResPeligroso")
            {
                puntaje = puntaje + 1;
            }
       }
    }
}
