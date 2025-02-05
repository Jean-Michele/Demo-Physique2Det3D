using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeuPoisson : MonoBehaviour
{
    [SerializeField] private float poidsSaumon = 10.5f;
    [SerializeField] private float poidsSardine = 1.5f;
    [SerializeReference] private GameObject _sardine;
    [SerializeReference] private GameObject _saumon;

    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ComparerPoissons()
    {
         if (poidsSardine > poidsSaumon){
            Debug.Log(poidsSardine);
            _saumon.SetActive(false);
            _sardine.SetActive(true);
        }
        else{
            Debug.Log(poidsSaumon);
            _sardine.SetActive(false);
            _saumon.SetActive(true);
        }

        if (poidsSardine < 0){
            poidsSardine = 0;
        }
        else if(poidsSaumon < 0){
            poidsSaumon = 0;
        }
    }
}
