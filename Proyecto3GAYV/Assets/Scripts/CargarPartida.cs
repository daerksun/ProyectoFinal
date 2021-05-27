using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class CargarPartida : MonoBehaviour
{
    public static bool Cargando;
    public Button ButtonCP; //Botón de cargar partida
    // Start is called before the first frame update
    void Start()
    {
        //ButtonCP.interactable = PlayerPrefs.GetFloat("Player x") == null && PlayerPrefs.GetFloat("Player z") == null;
        ButtonCP.interactable = PlayerPrefs.HasKey("Player z");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cargar()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("Nivel"));
        Cargando = true;
    }
}
