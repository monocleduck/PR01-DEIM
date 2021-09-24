using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THIRDsegundej : MonoBehaviour
{
    void Matematico (int Num1, int Num2,string operacion)
    {
        if(operacion == "/"){

            int Num3 = Num1 / Num2;

            if (Num3 % 2 == 0)
            {
                print(Num3 + " además es un número par");
            }

            else
            {
                print(Num3 + " además es un número impar");
            }
           
        }

        else if(operacion == "+")
        {
            int Num3 = Num1 + Num2;

            if (Num3 % 2 == 0)
            {
                print(Num3 + " además es un número par");
            }

            else
            {
                print(Num3 + " además es un número impar");
            }
        }

        else if (operacion == "-")
        {
            int Num3 = Num1 - Num2;

            if (Num3 % 2 == 0)
            {
                print(Num3 + " además es un número par");
            }

            else
            {
                print(Num3 + " además es un número impar");
            }
        }
        
        else if (operacion == "*")
        {
            int Num3 = Num1 * Num2;

            if (Num3 % 2 == 0)
            {
                print(Num3 + " además es un número par");
            }

            else
            {
                print(Num3 + " además es un número impar");
            }
        }

        else
        {
            print("la opercaion entregada no es valida");
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        Matematico(3,5,"*");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
