using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour {
    [SerializeField] private float xAxisSpeed = 5f;
    [SerializeField] private float zAxisSpeed = 10f;
    private PlayerInputActions playerInputActions;
    private void Awake() {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }
    void Update() {
        Vector3 direction = playerInputActions.Player.Move.ReadValue<Vector3>() * (Time.deltaTime * xAxisSpeed);
        
        transform.localPosition += direction;
        
        ClampXPosition();

        transform.position += transform.forward * (Time.deltaTime * zAxisSpeed);
    }
    private void ClampXPosition() {

        Vector3 pos = transform.localPosition;
        pos.x = Mathf.Clamp(pos.x, -5f, 5f);
        transform.localPosition = pos;
    }
}
