using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityScript : MonoBehaviour
{
    Vector2 speed;
    // Update is called once per frame
    void Start()
    {
        Vector2 speed = new Vector2(2, 0);
        GetComponent<Rigidbody2D>().velocity = speed;

    }
   


    }

    

