using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tercerej : MonoBehaviour
{

    public int Num1 = 43;
    public int Num2 = 6;
    public int Num3 = 27;
    public int Num4 = 38;

    public string palabra = "pelota";
    public string palabra2 = "para patos";

    // Start is called before the first frame update
    void Start()
    {
        int Num5 = Num2 * Num1;

        print(Num3 + Num4 + Num5);


        print(palabra + " " + palabra2 + "."); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
