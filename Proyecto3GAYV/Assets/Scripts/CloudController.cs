using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    private int cont=0;
    public int velocidad = 10;
    public float rangopos = 0.0f;
    public float rangoneg = 0.0f;
    private Vector3 PosicionInicial;
    private Vector3 PosicionInicial2;
    // Start is called before the first frame update
    void Start()
    {
        PosicionInicial = this.transform.position;
        PosicionInicial2 = new Vector3(rangoneg,PosicionInicial.y,PosicionInicial.z);
    }

    // Update is called once per frame
    void Update()
    {
        PosicionInicial = this.transform.position;
        if(PosicionInicial.x > rangopos)
        {
            this.transform.position = PosicionInicial2;
        }
        else if(PosicionInicial.x < rangopos)
        {
            this.transform.Translate(Vector3.right * this.velocidad * Time.deltaTime);
        }
    }
}
