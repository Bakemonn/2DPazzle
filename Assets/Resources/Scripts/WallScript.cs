using System.Collections;using System.Collections.Generic;using UnityEngine;public class WallScript : MonoBehaviour {
    
    public GameObject gcobj;    public GameController gcsc;    void Start()
    {        gcobj = GameObject.Find("GameController");        gcsc = gcobj.GetComponent<GameController>();
    }    void OnHand()    {        if (Input.GetMouseButton(0) && GameController.nowblock != 0)        {            GameController.nowblock = 0;            Debug.Log("In");        }    }}