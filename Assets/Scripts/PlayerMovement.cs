using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private float speed;

    private void Reset()
    {
        speed = 12f;
    }

    private void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
        
        var objTransform = transform;
        var move = objTransform.right * x + objTransform.forward * z;

        var moveSpeed = move * speed;
        if (Input.GetKeyDown(KeyCode.LeftShift))
            moveSpeed *= 2;
        controller.Move(moveSpeed * Time.deltaTime);
    }
}
