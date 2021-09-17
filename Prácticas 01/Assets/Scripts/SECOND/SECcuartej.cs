using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SECcuartej : MonoBehaviour
{

    private int x;

    // Start is called before the first frame update
    void Start()
    {
        while (x != 7)
        {
            x = Random.Range(0, 15);

            print("el numero es " + x);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
