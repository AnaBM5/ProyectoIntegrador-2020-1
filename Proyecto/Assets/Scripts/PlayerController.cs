﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 initialPosition;

    private Vector2 mousePosition;


    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDrag()
    {
	    if(!ChooseOption.answered){
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x, mousePosition.y - 1.2f);
	    }
    }

    private void OnMouseUp()
    {
        transform.position = initialPosition;
	    ChooseOption.answered = false;
    }
}