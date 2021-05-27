/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaRandomObjecto : MonoBehaviour
{
    public GameObject ObjetoPrueba;
    public float TiempoCreacion = 2f, RangoCreacion = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("Creando",0.0f,TiempoCreacion);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Creando()
    {
        Vector3 SpawnPosition = new Vector3 (0,0,0);
        SpawnPosition = this.transform.position;
        float valRandom = Random.Range(-6.45f,6.45f);
        SpawnPosition = new Vector3 (SpawnPosition.x + valRandom,SpawnPosition.y,SpawnPosition.z);

        ObjetoPrueba = Instantiate (ObjetoPrueba, SpawnPosition, Quaternion.identity);
    }
}*/
