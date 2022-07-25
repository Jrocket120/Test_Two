using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part_3_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Area(10, 3);       //Result should be 30
        //Area();            //Result should be 1
        //Area(2.5f, 3.7f);  //Result should be 9.25f
        int a = Area(10, 3);
        int b = Area();
        float c = Area(2.5f, 3.7f);
        print(a);
        print(b);
        print(c);
            
    }

    //Create a function called Area where you pass in two integer values and
    //return the Area value (1pt)
    int Area(int length=1, int width=1)
    {
        return length * width;
    }
    float Area(float length, float width)
    {
        return length * width;
    }
    //Add default values to the Area such that width = 1 and length = 1 (1pt)

    //Overload the function by creating another Area function but this one takes in
    //float values and returns a float  (1pt) 
}
