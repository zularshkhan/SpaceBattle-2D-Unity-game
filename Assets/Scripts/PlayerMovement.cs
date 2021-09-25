using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float mapsize;
    public Rigidbody2D rb;
    private float x;

    private void FixedUpdate()
    {
        x = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;
        Vector2 pos = rb.position + Vector2.up * x;
        pos.y = Mathf.Clamp(pos.y, -mapsize, mapsize);
        rb.MovePosition(pos);
    }
}
