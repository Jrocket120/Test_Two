using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part_3_2 : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;
    public GameObject cylinder;
    
    //Attach this Script to Part_3_Cube
    void Start()
    {
        //Using PrintOutNameAndPosition print out the name and position of the Part_3_Cube (1pt)

        //using GameObject.Find get the transform of Part_3_Sphere and use PrintOutNameAndPosition (1pt)

        //Using transform.Find or transform.Get get the Transform of Part_3_Cylinder which is a child of Part_3_Sphere
        //and use PrintOutNameAndPosition (1pt)


       PrintOutNameAndPosition("Cube", new Vector3(0, 0, 0));

       GameObject.Find("Sphere").GetComponent<Transform>();
       PrintOutNameAndPosition("Sphere", new Vector3(10, 2, -3));
       Transform trans=transform.Find("Cylinder").GetComponent<Transform>();
       PrintOutNameAndPosition("Cylinder", new Vector3(-10, 2, 4));



        //Prints out the name and the position of the variables

        void PrintOutNameAndPosition(string name, Vector3 pos) {
    


            print(name + " " + pos);
        }
     
    }

}
