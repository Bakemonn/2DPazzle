﻿using System.Collections;

    public GameObject gcobj;
        {

        }
        {
            if (selected)
            {
                Destroy(gameObject);
            }
        }
    {
        GameController.nowblock = 0;
    }
    {
        if (Input.GetMouseButton(0) && GameController.nowblock == 3 && selected != true)
        {
            GameController.nowblock = 1;
            Debug.Log("RED");
            selected = true;
        }
        else if (Input.GetMouseButton(0) && GameController.nowblock != 3 && selected != true)
        {
            GameController.nowblock = 0;
            Debug.Log("InR");
        }
    }