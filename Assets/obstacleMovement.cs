using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMovement : MonoBehaviour
{
    private Transform obstaclesTransform;
    public float obstacleSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        obstaclesTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        obstaclesTransform.position += new Vector3(0, 0, -obstacleSpeed);
    }
}
