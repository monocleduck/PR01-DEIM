using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class THRIDtercerej : MonoBehaviour
{


    public int x = 0;
    public int y = 0;
    public int z = 0;
    public Text timer;


    // Start is called before the first frame update
    void Start()
    {
       


        StartCoroutine("Contador");
    }

    IEnumerator Contador()
    {


        while (true)
        {
            print("la hora es " + z + " : " + y + " : " + x);
            

            timer.text = "la hora es " + z + " : " + y + " : " + x;
            x++;
            yield return new WaitForSeconds(1f);

            if (x == 60)
            {
                x = 0;
                y++;
            }

            else if (y == 60)
            {
                y = 0;
                z++;
            }
            
            else if (z == 2)
            {
                StopCoroutine("Contador");
            }
        
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
