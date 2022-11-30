using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public SnakeMovment mainSnake;
    //private Vector3 _offset;

    public Transform target;
    public float smooth = 5.0f;
    public Vector3 offset = new Vector3(5, 12, 2);

    private void Start()
    {
        //_offset = transform.position - mainSnake.transform.position;
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * smooth);
        //transform.position = mainSnake.transform.position + _offset;
    }

    void LateUpdate()
    {
        float x = 5; // вычисляете, на что сменить.
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
