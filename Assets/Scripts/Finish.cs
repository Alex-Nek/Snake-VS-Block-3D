using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out SnakeMovment snake)) return;
        snake.ReachFinish();
    }
}
