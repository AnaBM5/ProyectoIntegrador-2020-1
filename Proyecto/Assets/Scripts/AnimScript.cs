﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimScript : MonoBehaviour
{

    public Animator canvasAnim;

    public void canvasShake()
    {
        canvasAnim.SetTrigger("Damage");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
