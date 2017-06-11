using System.Collections;using System.Collections.Generic;using UnityEngine;public class GameController : MonoBehaviour {    public static int nowblock;    public GameObject redblockobj;    public GameObject greenblockobj;    public GameObject blueblockobj;

    public GameObject cliobj;

    

    // Use this for initialization
    void Start () {        nowblock = 0;
    }		// Update is called once per frame	void Update () {

        //メインカメラ上のマウスカーソルのある位置からRayを飛ばす
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            cliobj = hit.collider.gameObject;

            cliobj.SendMessage("OnHand");
        }

    }}