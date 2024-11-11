using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D _componentRigidbody2D;
    private float _x;
    private float _y;

    private void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _x = Input.GetAxis("Horizontal");
        _y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        _componentRigidbody2D.velocity = new Vector2(_x,_y);
    }
    
}
