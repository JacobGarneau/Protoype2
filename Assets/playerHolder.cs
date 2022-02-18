using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHolder : MonoBehaviour
{
    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z != 0f)
        {
            playerTransform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, 0f);
        }
    }
}
