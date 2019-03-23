﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSnap : MonoBehaviour
{
    int upCount = 1;
    int downCount = 1;
    float movement = 1.8f;
    public int speed = 5;
    private Rigidbody2D rb2d;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector2(transform.localScale.x * speed, rb2d.velocity.y);

        if (Input.GetKeyDown("w") && upCount < 2) {
            transform.Translate(0, movement, 0);
            upCount++;
            downCount--;
        } else if (Input.GetKeyDown("s") && downCount < 2) {
            transform.Translate(0, -movement, 0);
            downCount++;
            upCount--;
        } 
    }
}
