using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubito : MonoBehaviour
{

    void Start()
    {
    }


    void Update()
    {
        
    }
    public void movimiento (string direccion) 
    {
        if (direccion == "x+1") transform.Translate(1, 0, 0);

        if (direccion == "x-1") transform.Translate(-1, 0, 0);

        if (direccion == "y+1") transform.Translate(0, 1, 0);

        if (direccion == "y-1") transform.Translate(0, -1, 0);

        if (direccion == "z+1") transform.Translate(0, 0, 1);

        if (direccion == "z-1") transform.Translate(0, 0, -1);

        if (direccion == "0") transform.position = new Vector3(0, 0, 0);

    }
    public void tamaño (string tipo)
    {
        if (tipo == "resta") transform.localScale = transform.localScale + new Vector3(-1f, -1f, -1f);

        if (tipo == "suma") transform.localScale = transform.localScale + new Vector3(1f, 1f, 1f);
    }

    public void rotacion (string direccion)
    {
        if (direccion == "x+1") transform.Rotate(1f, 0, 0);

        if (direccion == "x-1") transform.Rotate(-1f, 0, 0);

        if (direccion == "y+1") transform.Rotate(0, 1f, 0);

        if (direccion == "y-1") transform.Rotate(0, -1f, 0);

        if (direccion == "z+1") transform.Rotate(0, 0, 1f);

        if (direccion == "z-1") transform.Rotate(0, 0, -1);

        if (direccion == "0") transform.rotation = new Quaternion(0, 0, 0, 0);
       
    }
}
