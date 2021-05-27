using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public CollisionBoteB colision;
    bool active;
    Canvas CanvasGameOver;

    // Start is called before the first frame update
    void Start()
    {
        CanvasGameOver = GetComponent<Canvas>();
        CanvasGameOver.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(colision.vida == 0)
        {
            checarVida();
            colision.vida = colision.vida-1;
        }
        
    }
    public void checarVida()
    {
        active = !active;
        CanvasGameOver.enabled = active;
        Time.timeScale = (active) ? 0f : 1f;

    }
}
