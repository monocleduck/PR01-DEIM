using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SECsecondej : MonoBehaviour
{
    private int x = 20;

    // Start is called before the first frame update
    void Start()
    {
        while(x > 0){

            print("el numero es " + x);

            x--;
        }
    
        //FOR

        for(int y = 20; y> 0; y--)
        {
            print("el numero es " + y);
        }
    
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
