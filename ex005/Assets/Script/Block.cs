using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
    GameObject sword;
    Sword FallSword;
    // Use this for initialization
    void Start () {
        sword = GameObject.Find("SwordObject");
        FallSword = sword.GetComponent<Sword>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * FallSword.FallSpeed * Time.deltaTime);



        if (transform.position.y > 10)
        {
            Destroy(gameObject);
        }








    }
}
