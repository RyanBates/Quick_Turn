using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behaviour : MonoBehaviour
{
    public Player_Stats character;

    float health;
    public float speed;

    float horizontal;
    float vertical;

    public bool moving = false;
    public bool quickTurn;

    void Start()
    {
        health = character.health;
    }

    void Update()
    {
        character.position = transform.position;
        speed = character.speed;

        //if (speed <= 0.0f)
        //    moving = false;

        //if (moving == true)
        //    speed += character.acceleration;

        //if (moving == false)
        //{
        //    speed -= character.acceleration;
        //    speed = 0;
        //}

        if (speed <= character.max_Speed)
            if(moving == true)
                character.speed += character.acceleration;

        if (speed >= character.max_Speed)
        {
            speed = character.max_Speed;
        }



        horizontal += Input.GetAxis("Horizontal") * speed;
        vertical += Input.GetAxis("Vertical") * speed;

        transform.position = new Vector3(horizontal, .5f, vertical);


    }

}
