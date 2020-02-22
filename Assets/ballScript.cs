using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ballScript : MonoBehaviour {

    public float v, a;
    int color;
    public Color [] c; 
    barScript bs;
    public GameObject ggps, cps;
    Rigidbody2D rb;
	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>(); 
        rb.velocity = new Vector3(0, -v, 0);
        color = 0;
        PlayerPrefs.SetInt("score", 0);
        if (!PlayerPrefs.HasKey("hscore"))
            PlayerPrefs.SetInt("hscore", 0);
        InvokeRepeating("aclr", 2f, 2f); 
	}
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D collision) {
        bs = collision.gameObject.GetComponent<barScript>();
        if (bs.color != color){
            int strk = StrikeScript.upd(true);
            if (strk >= 3) {
                GameObject go = Instantiate(ggps);
                go.transform.position = transform.position;
                Debug.Log(transform.position);
                Destroy(gameObject.GetComponent<SpriteRenderer>());
                Destroy(gameObject.GetComponent<BoxCollider2D>());
                Destroy(go, 2f); Invoke("gg", 2f); 

            }
            //
        } else {
            StrikeScript.upd(false);
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1); 
            GameObject tps = Instantiate(cps);
            tps.transform.position = transform.position;
            var main = tps.GetComponent<ParticleSystem>().main;
            main.startColor = c[color];  
            Destroy(tps, 2f);
            color = Random.Range(0, 4); 
            /*int tmp = Random.Range(0, 3);
            color = (tmp == color) ? 3 : tmp;*/
            gameObject.GetComponent<SpriteRenderer>().color = c[color];
            rb.velocity = rb.velocity.normalized * v;
        }
    } 
    void gg (){
        PlayerPrefs.SetInt("hscore", Mathf.Max(PlayerPrefs.GetInt("hscore"), PlayerPrefs.GetInt("score")));
        SceneManager.LoadScene("ggscene", LoadSceneMode.Single); 
    }
    void aclr() { v += a;  }
}
