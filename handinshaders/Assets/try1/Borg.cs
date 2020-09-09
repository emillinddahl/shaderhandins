using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borg : MonoBehaviour
{

    public GameObject cube;
    public GameObject[] mega;

    //change shit up
    public float borgCubeAmount = 20;
    //three dimensional array and put cubes in there - hmm

    // Start is called before the first frame update
    void Start()
    {

        for (int z = 0; z < borgCubeAmount; z++) { 
        
            for (int y = 0; y < borgCubeAmount; y++) {

                for (int x = 0; x < borgCubeAmount; x++)
                {

                    //GameObject theNewestCube = Instantiate(cube, transform.position + new Vector3(x - 20, 0, 0), Quaternion.identity) as GameObject;
                    //GameObject theNewestCube = Instantiate(cube, new Vector3((x - 5) / 8f, (y - 5) / 8f, (z - 5) / 8f), transform.rotation) as GameObject;
                    GameObject theNewestCube = Instantiate(cube, new Vector3((x - borgCubeAmount) / 8f, (y - borgCubeAmount) / 8f, (z - borgCubeAmount) / 8f), transform.rotation) as GameObject;

                    // color is given in RGB
                    theNewestCube.GetComponent<Renderer>().material.color = new Color(x / borgCubeAmount, y/borgCubeAmount, z / borgCubeAmount);

                    //assume that the newestcube is an object that needs moving to orbit earth/sun, atm it is stuck at the instantiated position.

                    Vector3 GetCoordinates()
                    {
                        return new Vector3(
                            x - (borgCubeAmount - 1) * 0.5f,
                            y - (borgCubeAmount - 1) * 0.5f,
                            z - (borgCubeAmount - 1) * 0.5f
                            );
                    }


                }

            }

        }

     
    }

    // Update is called once per frame
    void Update()
    {
        
    }




}
