using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public GameObject[] estrellas;
    public int NumPuntos;
    public CollisionBoteB colision;
    bool active;
    Canvas Canvas_LevelCompleted;
    // Start is called before the first frame update
    void Start()
    {
        Canvas_LevelCompleted = GetComponent<Canvas>();
        Canvas_LevelCompleted.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(colision.puntaje == NumPuntos)
        {
            siguientenivel();
            colision.puntaje = 0;
        }
        if(colision.vida == 1)
        {
            Destroy(estrellas[1].gameObject);
            //gameOver.checarVida();
        }
        else if(colision.vida == 2)
        {
            Destroy(estrellas[2].gameObject);
        }
    }

    void siguientenivel()
    {
        active = !active;
        Canvas_LevelCompleted.enabled = active;
        Time.timeScale = (active) ? 0f : 1f;
    }


}
