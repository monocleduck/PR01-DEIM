using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOURTHprimerej2j : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartCalc()
    {
        while (true)
        {
                
                
                yield return new WaitForSeconds(2f);

            }
        }

    void Matematico(int Num1, int Num2, string operacion)
    {
        if (operacion == "/")
        {

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

        else if (operacion == "+")
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








}

