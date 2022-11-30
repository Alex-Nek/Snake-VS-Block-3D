using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Food : MonoBehaviour
{
    public int CountFood;
    public TextMeshPro textCountFood;

    public int MaxValue;
    public int MinValue;

    //private int AddHP = 0;

    public void Awake()
    {
        CountFood = Random.Range(MinValue, MaxValue + 1);

        for (int i = 0; i < CountFood; i++)
        {
            textCountFood.text = CountFood.ToString();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //if (AddHP < CountFood)
            //{
            //other.GetComponent<SnakeMovment>().AddTail();
            //AddHP++;
            //return;
            //}
            other.GetComponent<SnakeMovment>().AddTail();
            Destroy(gameObject);
        }
    }
}
