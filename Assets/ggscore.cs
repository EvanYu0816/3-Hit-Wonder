using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ggscore : MonoBehaviour {
    public GameObject sc, hsc; 
	void Start () {
        TextMeshProUGUI tmp1 = sc.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI tmp2 = hsc.GetComponent<TextMeshProUGUI>();
        tmp1.text = "Score: " + PlayerPrefs.GetInt("score");
        tmp2.text = "High Score: " + PlayerPrefs.GetInt("hscore"); 
	}
}
