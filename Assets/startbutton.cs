using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class startbutton : MonoBehaviour {

    public string scene; 
	
    void OnMouseUp() {
        SceneManager.LoadScene(scene, LoadSceneMode.Single); 
    }
}
