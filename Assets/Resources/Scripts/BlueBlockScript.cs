﻿using System.Collections;
        if (Input.GetMouseButtonUp(0))
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
        if (Input.GetMouseButton(0) && GameController.nowblock == 2 && selected != true)
        {
            GameController.nowblock = 3;
            Debug.Log("BLUE");
            selected = true;
        }
        else if(Input.GetMouseButton(0) && GameController.nowblock != 2 && selected != true)
        {
            GameController.nowblock = 0;
            Debug.Log("InB");
        }
    }
    {
        if (selected)
        {
            Destroy(gameObject);
        }
    }