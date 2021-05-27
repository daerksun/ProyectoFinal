using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarYGuardar : MonoBehaviour 
{
    public PruebaLevel NivAct;
    public string nive;
    public GameObject Player;
    //public GameObject NivelRetry;
    private string NivelaGuardar;
    // Start is called before the first frame update
    void Start()
    {
        //Player = GameObject.FindGameObjectWithTag("MuñecoNieveBrincando");
        if(CargarPartida.Cargando)
        {
            Player.transform.position = new Vector3(PlayerPrefs.GetFloat("Player x"),PlayerPrefs.GetFloat("Player y"),PlayerPrefs.GetFloat("Player z"));
            NivAct.NivelActual = PlayerPrefs.GetString("Nivel");
        }
            
    }

    // Update is called once per frame
    public void Guardar()
    {
        PlayerPrefs.SetFloat("Player x", Player.transform.position.x);
        PlayerPrefs.SetFloat("Player y", Player.transform.position.y);
        PlayerPrefs.SetFloat("Player z", Player.transform.position.z);
        //PlayerPrefs.SetString("Nivel", Player.GetComponent<);
        PlayerPrefs.SetString("Nivel",nive);
        PlayerPrefs.Save();
    }

    public void Borrar()
    {
        PlayerPrefs.DeleteKey("Player x");
        PlayerPrefs.DeleteKey("Player z");
    }
}
