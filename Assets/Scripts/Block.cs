using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class Block : MonoBehaviour
{
    public int CountBlock;
    public TextMeshPro countTextBlock;

    public int MaxValue;
    public int MinValue;
    //private int BlockHP;

    public SnakeMovment SnakeHP;

    public void Awake()
    {
        int CountBlock = Random.Range(MinValue, MaxValue + 1);

        for (int i = 0; i < CountBlock; i++)
        {
            countTextBlock.text = CountBlock.ToString();
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<SnakeMovment>().DivTail();
            Destroy(gameObject);
        }
    }
}