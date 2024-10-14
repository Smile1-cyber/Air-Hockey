using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Camera cam;
    Rigidbody2D rb;
    public float speed = 10;
    private Vector3 worldPos;

    void Start()
    {
        Cursor.visible  = false;
        Cursor.lockState = CursorLockMode.Confined;
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        worldPos = cam.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;
        transform.position = worldPos;
        rb.MovePosition(worldPos);
    }

    void FixedUpdate()
    {
        var targetPos = Vector2.MoveTowards(transform.position, worldPos, speed * Time.fixedDeltaTime);
        rb.MovePosition(targetPos);
    }
}
