using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] private GameObject _wholeLemon;
    [SerializeField] private GameObject _cutLemon;
    [SerializeField] private GameObject _wholeButter;
    [SerializeField] private GameObject _cutButter;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lemon"))
        {
            _wholeLemon.SetActive(false);
            _cutLemon.SetActive(true);
            var halves = _cutLemon.GetComponentsInChildren<Rigidbody>();
            foreach (var half in halves)
            {
                half.isKinematic = false;
            }
        }
        
        if (other.CompareTag("Butter"))
        {
            _wholeButter.SetActive(false);
            _cutButter.SetActive(true);
            var halves = _cutButter.GetComponentsInChildren<Rigidbody>();
            foreach (var half in halves)
            {
                half.isKinematic = false;
            }
        }
    }
}
