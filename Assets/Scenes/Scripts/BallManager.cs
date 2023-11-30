using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEditor;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.EventSystems;

public class BallManager : MonoBehaviour
{
    private Vector3 _moveDirection;
    [SerializeField] private float speed;
    private bool IsGrounded;

    [SerializeField] private LayerMask groundLayers;
    private float depth;

    void Start()
    {
        InputManager.Init(myPlayer: this);
        InputManager.SetManager();
    }

    
    void Update()
    {
        transform.position += _moveDirection * speed * Time.deltaTime;
        CheckGrounded();
    }
    public void SetMovementDirection(Vector3 currentDirection)
    {
        _moveDirection = currentDirection;

    }
    private void CheckGrounded()
    {
        IsGrounded = Physics.Raycast(origin: transform.position, direction: Vector3.down, depth, groundLayers);
        Debug.DrawRay(transform.position, Vector3.down * depth, Color.blue, 0, false);

        if (!IsGrounded ) 
        {
            return;

        }
       
        
    }
    


}
