using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOURTHprimerej : MonoBehaviour
{
    void Saludo(string hola)
    {
        print("hola " + hola);
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {

            StartCoroutine("Contador");
            
        }

        else if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StopCoroutine("Contador");
        }

      

    }



    IEnumerator Contador()
    {
        while (true)
        {
            Saludo("zapato");
            Saludo("chancla");

            yield return new WaitForSeconds(2f);

        }

    }
}
