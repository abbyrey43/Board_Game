using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //this script must be attached to a game object in your scene to be used
    //you can do this by dragging it onto the gameObject

    //declare a new public vector3
    //public means we can assign it in the inspector
    //to give it an initial assignment, we have to use new Vector3(xValue, yValue, zValue)
    public Vector3 pos = new Vector3(5f, 5f, 5f); //float values should be followed by the letter f
    public Transform playerPiece; //store the transform of our playerPiece ... dont forget to assign it in the inspector
    float tileAmount = 1f;
    public Transform hazard;
    public Transform obstacle;
    public Transform[] manyHazards;
    public Vector3 playerStart;

    // Start is called before the first frame update
    void Start()
    {
        //store our starting position with playerStart
        playerStart = playerPiece.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Keys can be specified using KeyCode
        if (Input.GetKeyDown(KeyCode.W))
        {

            //modify the playerPiece position by tileAmount on the z axis
            playerPiece.position += new Vector3(0f, 0f, tileAmount);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //we can use - to move it the opposite direction
            playerPiece.position += new Vector3(0f, 0f, -tileAmount);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {

            playerPiece.position += new Vector3(1f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {

            playerPiece.position += new Vector3(-1f, 0f, 0f);
        }

        //if the position of our hazard (dont forget to assign it in the inspector) is the same position as our player piece...
        if (hazard.position == playerPiece.position)
        {
            playerPiece.position = playerStart; //then reset the position to the starting position
        }
    }   
    
    if (manyHazards[i].position == playerPiece.position) {playerPiece.position = playerStart;private class manyHazards
    {
    }
}
}        {
            newPos += new Vector3(0f, -tileAmount, 0f); //update newPos to be our potential new position
        }
        if (obstacle.position != newPos) //only update our playerPiece position if it is NOT the same as the obstacle
        {
            //update the playerpiece pos to be the newPos
            playerPiece.position = newPos;
        }
    //if the position of our hazard (dont forget to assign it in the inspector) is the same position as our player piece...
        for (int i = 0; i<manyHazards.Length; i++) //use a loop to check each one of the positions in our transform array (manyhazards)
        {
            playerPiece.position = playerStart; //then reset the position to the starting position
            if (manyHazards[i].position == playerPiece.position) //check if our playerpiece is in the same position as this particular one from manyHazards
           
        }
    }
}