using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    public static int score;
    public GameObject obj;

	// Use this for initialization
	void Start () {
        score = 0;
        obj = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        obj.GetComponent<Text>().text = score.ToString();
	}
}
