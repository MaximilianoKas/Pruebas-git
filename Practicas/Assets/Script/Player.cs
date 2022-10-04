using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float vida = 200;
    [SerializeField] float velocidad = 1;
    [SerializeField] Vector3 direccion;
    

    void Start()
    {

    }

    void Update()
    {
        Movimiento();
        CuraJugador();
        //DaņoJugador();

    }

    public void Movimiento()
    {
        transform.position += direccion * velocidad * Time.deltaTime;
    }

    public void CuraJugador()
    {
        vida += 1 * Time.deltaTime;
    }

    public void DaņoJugador()
    {
        vida -= 1 * Time.deltaTime;
    }
}
