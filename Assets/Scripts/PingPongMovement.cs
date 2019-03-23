using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongMovement : MonoBehaviour
{
    [SerializeField]
    float _speed = 5;
    [SerializeField]
    float _amount = 1;

    Vector3 _startPos;


    private void Start()
    {
        _startPos = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, _startPos.y + Mathf.PingPong(Time.time * _speed * Time.deltaTime, _amount));
    }
}
