using System.Collections;using System.Collections.Generic;using UnityEngine;public class RedBlockScript : MonoBehaviour {

    public GameObject gcobj;    public GameController gcsc;    public bool selected;    // Use this for initialization    void Start()    {        selected = false;        gcobj = GameObject.Find("GameController");        gcsc = gcobj.GetComponent<GameController>();    }    // Update is called once per frame    void Update()    {        if(GameController.nowblock != 0)
        {

        }        if (Input.GetMouseButtonUp(0))
        {
            if (selected)
            {
                Destroy(gameObject);
            }
        }    }    void OnMouseDown()    {        GameController.nowblock = 1;        Debug.Log(GameController.nowblock);        selected = true;    }    void OnMouseUp()
    {
        GameController.nowblock = 0;        Debug.Log(GameController.nowblock);
    }    void OnHand()
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
    }}