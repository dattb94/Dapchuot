using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Local : MonoBehaviour {

    public GameObject chicken;

    public Transform chickenParent;

    public float time = 0;
    int maxTime;

    // Use this for initialization
    void Start () {
        maxTime = UnityEngine.Random.Range(1, 4);
    }
	
	// Update is called once per frame
	void Update () {
        CalculateSpawnChicken();
	}
    void CalculateSpawnChicken()
    {
        time += Time.deltaTime;
        if (time > maxTime)
        {
            if (chickenParent.childCount < MainController.maxChickenInScene)
            {
                SpawnChicken();
            }
            maxTime = UnityEngine.Random.Range(5,10);
            time = 0;
        }
    }

    private void SpawnChicken()
    {
        GameObject _chicken = (GameObject)Instantiate(chicken, transform.position, transform.rotation);
        _chicken.transform.SetParent(chickenParent);
        Destroy(_chicken, 1);
    }
}
