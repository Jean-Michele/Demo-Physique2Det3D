using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeuPoisson : MonoBehaviour
{
    [SerializeField] private float poidsSaumon = 10.5f;
    [SerializeField] private float poidsSardine = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        if (poidsSardine > poidsSaumon){
            Debug.Log(poidsSardine);
        }
        else{
            Debug.Log(poidsSaumon);
        }

        if (poidsSardine < 0){
            poidsSardine = 0;
        }
        else if(poidsSaumon < 0){
            poidsSaumon = 0;
        }
    }
}
