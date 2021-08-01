using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{

    [SerializeField] float Speed = 4f;
    Rigidbody2D controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMoviment();
    }

    void UpdateMoviment()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * Speed;
        controller.velocity = new Vector2(moveBy, controller.velocity.y);
    }
}
