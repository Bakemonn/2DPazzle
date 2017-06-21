using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour {

    public void LoadGameScene(){
        SceneManager.LoadScene("Main");
	}
	
    public void LoadGalleryScene()
	{
		SceneManager.LoadScene("Gallery");
	}
}
