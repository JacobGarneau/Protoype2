using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 camTarget = new Vector3(6f, 2.75f, 0f);
    private float cameraMoveSpeed = 0.003f;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (mainCamera.transform.position.x < camTarget.x)
        {
            mainCamera.transform.position += new Vector3(cameraMoveSpeed, 0f, 0f);
        }

        if (mainCamera.transform.position.x > camTarget.x)
        {
            mainCamera.transform.position -= new Vector3(cameraMoveSpeed, 0f, 0f);
        }

        if (mainCamera.transform.position.y < camTarget.y)
        {
            mainCamera.transform.position += new Vector3(0f, cameraMoveSpeed, 0f);
        }

        if (mainCamera.transform.position.y > camTarget.y)
        {
            mainCamera.transform.position -= new Vector3(0f, cameraMoveSpeed, 0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // HANDLE OBSTACLE COLLISION

        if (collision.collider.gameObject.tag == "Obstacle")
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        // HANDLE CAMERA POSITION COLLIDERS

        if (collision.collider.gameObject.tag == "center")
        {
            Destroy(collision.collider.gameObject);
            
            camTarget = new Vector3(6f, 2.75f, 0f);
        }

        if (collision.collider.gameObject.tag == "addUp")
        {
            Destroy(collision.collider.gameObject);
            camTarget = new Vector3(9f, 5.25f, 0f);
        }

        if (collision.collider.gameObject.tag == "addLow")
        {
            Destroy(collision.collider.gameObject);
            camTarget = new Vector3(9f, -0.25f, 0f);
        }

        if (collision.collider.gameObject.tag == "addAll")
        {
            Destroy(collision.collider.gameObject);
            camTarget = new Vector3(13.75f, 2.75f, 0f);
        }
    }
}
