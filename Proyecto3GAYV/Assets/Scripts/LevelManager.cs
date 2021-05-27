using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        public void CargaTodosNiveles(string pTodosNiveles)
    {
        //cargarvariable(pTodosNiveles);
        if(pTodosNiveles == "Menu")
            SceneManager.LoadScene(pTodosNiveles);
        else if(pTodosNiveles == "Nivel1")
            SceneManager.LoadScene(pTodosNiveles);
        else if(pTodosNiveles == "Nivel2")
            SceneManager.LoadScene(pTodosNiveles);
        else if(pTodosNiveles == "Nivel3")
            SceneManager.LoadScene(pTodosNiveles);
        else if(pTodosNiveles == "Reglas")
            SceneManager.LoadScene(pTodosNiveles);
        else if(pTodosNiveles == "Niveles")
            SceneManager.LoadScene(pTodosNiveles);
        else if(pTodosNiveles == "Creditos")
            SceneManager.LoadScene(pTodosNiveles);
        pTodosNiveles=null;
        //SceneManager.LoadScene(pNombreReglas);
    }
}
