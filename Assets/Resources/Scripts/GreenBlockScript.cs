﻿using System.Collections;

    public bool selected;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (selected)
            {
                Destroy(gameObject);
            }
        }
    }
    {
        GameController.nowblock = 0;
    }
    {
        if (Input.GetMouseButton(0) && GameController.nowblock == 1 && selected != true)
        {
            GameController.nowblock = 2;
            Debug.Log("GREEN");
            selected = true;
        }
        else if (Input.GetMouseButton(0) && GameController.nowblock != 1 && selected != true)
        {
            GameController.nowblock = 0;
            Debug.Log("InG");
        }
    }
    {
        if (selected)
        {
            Debug.Log("Test");
            Destroy(gameObject);
        }
    }