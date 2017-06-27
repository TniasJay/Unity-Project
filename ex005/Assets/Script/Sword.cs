using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {
    public float direction=0.0f;
    public float RotationSpeed = 10.0f;
    public float speed = 1.0f;
    private float direct;
    public float distance;
    public float FallSpeed;
    public float BaseFallSpeed=1.0f;
    public GameObject PreB = null;
    private int PreDist=0;
    //public GameObject block = null;
    
	// Use this for initialization
	void Start () {
        transform.eulerAngles = new Vector3(0, 0, 315);
        distance = 0;
        Instantiate(PreB, new Vector3(0, -4.4f, 0), PreB.transform.rotation);

    }
	
	// Update is called once per frame
	void Update () {

        float rotation = Input.GetAxis("Horizontal") * RotationSpeed * Time.deltaTime;
        float mot;

        direct=transform.eulerAngles.z;

       

        if ((direct+rotation>35)&&(direct+rotation<235))
        {
            rotation = 0;
            
        }

        if ((direct + rotation) < 310 && (direct + rotation) > 235)
            mot = -speed * Time.deltaTime;
        else if (((direct + rotation) > 320&& (direct + rotation)<360)||((direct + rotation)>=0&& (direct + rotation)<35))
            mot = speed * Time.deltaTime;
        else
            mot = 0;
        //if(transform.position.x<-2)
        transform.position = new Vector3(Mathf.Clamp((mot + transform.position.x), -2, 2), transform.position.y, transform.position.z);
        transform.Rotate(0, 0, rotation);
        FallSpeed = Mathf.Cos(Mathf.Deg2Rad*(transform.eulerAngles.z + 45))*BaseFallSpeed;
        distance = distance+FallSpeed * Time.deltaTime;

        if ((int)distance%2==0&&(int)distance!=PreDist)
        {
            Instantiate(PreB, new Vector3(0, -4.4f, 0), PreB.transform.rotation);
            PreDist = (int)distance;
        }

		//Test of method of input class
		//This is the vitual Key seted in "input" area
		if(Input.GetButtonDown("g"))
			print("Get the button of \"G\"");
		//This is the real Key on keyboard
		if (Input.GetKeyDown ("h"))
			print ("Get the button of \"H\"");

		//for git test




    }
}
