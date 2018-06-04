using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour {

    public enum typeChicken { white, yellow, brown }

    public typeChicken type;

    public GameObject white, yellow, brown;

    int scoreMake=0;

    // Use this for initialization
    void Start() {
        Initialization();
    }
    void Initialization()
    {
        white.SetActive(false);
        yellow.SetActive(false);
        brown.SetActive(false);

        type = Probability(80) ? typeChicken.white : Probability(15) ? typeChicken.yellow : typeChicken.brown;
        white.SetActive(type== typeChicken.white);
        yellow.SetActive(type == typeChicken.yellow);
        brown.SetActive(type == typeChicken.brown);

        scoreMake = type == typeChicken.white ? 1 : type == typeChicken.yellow ? 5 : -3;
    }

    bool Probability(int _percent)
    {
        int _x = UnityEngine.Random.Range(0,100);
        return _x <= _percent ? true : false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "hammerMapping")
        {
            MainController.score += scoreMake;
            Destroy(gameObject);
        }
    }
}