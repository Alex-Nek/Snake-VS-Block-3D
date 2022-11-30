using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SnakeMovment : MonoBehaviour
{
    public float Speed;
    public float RotationSpeed;

    public List<GameObject> tailObjects = new List<GameObject>();
    public GameObject TailPrefab;
    private int CountStartHP = 3;
    private int CountHP = 0;

    public Game Game;

    public float z_offset = 0.6f;

    void Start()
    {
        tailObjects.Add(gameObject);
    }
    
    void Update()
    {
        if (CountHP < CountStartHP)
        {
            AddTail();
            CountHP++;
        }

        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
        }        
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * RotationSpeed * Time.deltaTime);
        }
    }

    public void AddTail()
    {
        Vector3 newTailPos = tailObjects[tailObjects.Count - 1].transform.position;
        newTailPos.z -= z_offset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);
    }

    public void DivTail()
    {
        Destroy(tailObjects[tailObjects.Count - 1]);
        tailObjects.Remove(tailObjects.Last());
    }

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
    }
}
 