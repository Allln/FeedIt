﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatingText : MonoBehaviour
{
    public float DestroyTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,DestroyTime);
    }

}
