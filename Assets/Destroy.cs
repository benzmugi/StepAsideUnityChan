using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    private GameObject unitychan;
    
    private float difference;


    // Use this for initialization
    void Start () {
        this.unitychan = GameObject.Find("unitychan");
        
        this.difference = unitychan.transform.position.z - Camera.main.transform.position.z;

    }

    // Update is called once per frame
    void Update () {

        if (this.transform.position.z < this.unitychan.transform.position.z - this.difference)
        {
            Destroy(this.gameObject);
        }

       
	}
}
