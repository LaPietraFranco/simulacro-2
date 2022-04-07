using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    public int n1;
    public int n2;
    // Start is called before the first frame update
    void Start()
    {
        if (n1 < n2)
        {
            Debug.Log("los numeros son distintos");
        }
        else if (n1 > n2)
        {
            Debug.Log("los numeros son distintos");
        }
        else
        {
            Debug.Log("los numeros son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
