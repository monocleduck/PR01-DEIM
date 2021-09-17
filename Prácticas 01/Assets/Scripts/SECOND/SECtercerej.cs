using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SECtercerej : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int x = 0; x<10; x++)
        {
            if (x < 5)
            {
                print("el numero es menor que 5");


            }

            else if(x==5){
                print("el numero es igual a 5");
            }

            else
            {
                print("el numero es mayor que 5");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
