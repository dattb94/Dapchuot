using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour {
    public float speed = 1;

    public GameObject hammerMapping;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        hammerMapping.transform.Translate(Input.GetAxis("Mouse X") * speed, 0, Input.GetAxis("Mouse Y") * speed);

       // hammerMapping.GetComponent<SphereCollider>().enabled = Input.GetMouseButtonDown(0);
    }
}
