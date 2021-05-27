using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCamera : MonoBehaviour
{
    public int cont;
    // Start is called before the first frame update
    public Camera Camara1;
    public Camera Camara2;
    //public GameObject BotonCa;
    bool aux = true;
    void Start()
    {
        //Camara1 = GameObject.Find("Main Camera")
        //cameraPositionChange(PlayerPrefs)
    }

    // Update is called once per frame
    /*void Update()
    {
        if(Input.GetKey(KeyCode.C))
        {
            Camara1.SetActive(true);
            Camara2.SetActive(false);
        }   
        else if(Input.GetKey(KeyCode.V))
        {
            Camara1.SetActive(false);
            Camara2.SetActive(true);
        }
    }*/
    void Update()
    {
        
    }
    public void SumarContador()
    {
        aux= !aux;
        SwitchCamera();
    }

    public void SwitchCamera()
    {
        if(aux == true)
        {
            Camara1.enabled = false;
            Camara2.enabled = true;
        }   
        else if(aux == false)
        {
            Camara1.enabled = true;
            Camara2.enabled = false;
        }
    }
}
