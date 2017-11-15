using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Player_Stats : ScriptableObject
{
    public float health = 100.0f;
    public float speed;
    public float max_Speed = 10.0f;
    public float acceleration = .5f;

    public Vector3 position;
}
