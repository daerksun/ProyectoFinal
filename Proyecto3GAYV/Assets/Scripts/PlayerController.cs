using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int velocidad = 10;
    //public int x;
    //public int vida;
    //public GameObject[] corazones;
    //public Vector2 sensibility;
    // Start is called before the first frame update
    void Start()
    {
        //vida = corazones.Length - x;
    }

    // Update is called once per frame
    void Update()
    {
        /*if(vida<1)
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
        }*/
        
        //Mover bote a la izquierda
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * this.velocidad * Time.deltaTime);
        }
        //Mover bote a la derecha
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * this.velocidad * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * this.velocidad * Time.deltaTime);
        }
        //Mover bote a la derecha
        if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * this.velocidad * Time.deltaTime);
        }
    }
}
