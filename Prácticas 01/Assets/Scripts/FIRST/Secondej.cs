using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secondej : MonoBehaviour
{
    public int Var5 = 4;    
    public float Var6 = 3.14f;
    [SerializeField] bool Var7 = true;
    [SerializeField] public string Var8 = "zaparilla";


    // Start is called before the first frame update
    void Start()
    {
        Var7 = false;

        print(Var5);
        print(Var6);
        print(Var7);
        print(Var8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
