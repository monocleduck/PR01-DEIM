using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THIRDsegundej : MonoBehaviour
{
    void Matematico (int Num1, int Num2,string operacion)
    {
        if(operacion == "/"){
            
            
            
            
            print(Num1 / Num2);
        }

        else if(operacion == "+")
        {
            print(Num1 + Num2);
        }

        else if (operacion == "-")
        {
            print(Num1 - Num2);
        }
        
        else if (operacion == "*")
        {
            print(Num1 * Num2);
        }

        else
        {
            print("la opercaion entregada no es valida");
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        Matematico(8,5,"*");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
