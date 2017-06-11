using System.Collections;using System.Collections.Generic;using UnityEngine;public class BlueBlockScript : MonoBehaviour {    public GameObject gcobj;    public GameController gcsc;    public bool selected;    // Use this for initialization    void Start()    {        selected = false;        gcobj = GameObject.Find("GameController");        gcsc = gcobj.GetComponent<GameController>();    }    // Update is called once per frame    void Update()    {
        if (Input.GetMouseButtonUp(0))
        {
            if (selected)
            {
                Destroy(gameObject);
            }
        }    }    void OnMouseDown()    {        GameController.nowblock = 3;        Debug.Log(GameController.nowblock);        selected = true;    }    void OnMouseUp()
    {
        GameController.nowblock = 0;        Debug.Log(GameController.nowblock);        
    }    void OnHand()
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
    }    public void DestroyBlue()
    {
        if (selected)
        {
            Destroy(gameObject);
        }
    }}