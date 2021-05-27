using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditosMov : MonoBehaviour
{
    public int velocidad = 100;
    private Vector3 PosicionInicial;
    private Vector3 PosicionInicial2;
    // Start is called before the first frame update
    void Start()
    {
        PosicionInicial = this.transform.position;
        PosicionInicial2 = new Vector3(PosicionInicial.x,-900.0f,PosicionInicial.z);
    }

    // Update is called once per frame
    void Update()
    {
        PosicionInicial = this.transform.position;
        if(PosicionInicial.y > 2600.0f)
        {
            this.transform.position = PosicionInicial2;
        }
        else if(PosicionInicial.y < 2600.0f)
        {
            this.transform.Translate(Vector3.up * this.velocidad * Time.deltaTime);
        }
    }
}
