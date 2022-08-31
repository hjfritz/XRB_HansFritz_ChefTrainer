using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class MeasuringCup : MonoBehaviour
{
    [SerializeField] private GameObject liquid1;
    [SerializeField] private GameObject liquid2;
    [SerializeField] private GameObject liquid3;
    [SerializeField] private GameObject liquid4;
    [SerializeField] private GameObject _text;

    private int amount = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AddCream()
    {
        amount += 1;
        if (amount == 1)
        {
            liquid1.SetActive(true);
            _text.GetComponent<TMP_Text>().text = "1/4 Cup";
        }else if (amount == 2)
        {
            liquid1.SetActive(false);
            liquid2.SetActive(true);
            _text.GetComponent<TMP_Text>().text = "1/2 Cup";
        }else if (amount == 3)
        {
            liquid2.SetActive(false);
            liquid3.SetActive(true);
            _text.GetComponent<TMP_Text>().text = "3/4 Cup";
        }else if (amount == 4)
        {
            liquid3.SetActive(false);
            liquid4.SetActive(true);
            _text.GetComponent<TMP_Text>().text = "1 Cup";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cream"))
        {
            AddCream();
        }
    }
}
