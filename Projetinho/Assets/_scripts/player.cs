using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    CharacterController controller;
    Vector3 velocidadeH;
    Vector3 velocidadeV;
    Vector3 velocidadefinal;
    public float speed;
    public float alturaMax;
    public float tempo;
    float JumpSpeed;
    float gravidade;
    void Start()
    {
        gravidade = 2 * alturaMax/ Mathf.Pow(tempo, 2); 
        controller = GetComponent<CharacterController>();
        JumpSpeed = gravidade * tempo;
    }


    private void FixedUpdate() {
        if(controller.isGrounded){
            velocidadeV = Vector3.down;
        }
        if(Input.GetKeyDown(KeyCode.Space) && controller.isGrounded){
            velocidadeV = JumpSpeed * Vector3.up;
        }
        velocidadeH = speed * Vector3.right * Input.GetAxis("Horizontal");
        velocidadeV += gravidade * Time.deltaTime * Vector3.down;
        velocidadefinal = velocidadeH + velocidadeV;
        controller.Move(velocidadefinal * Time.deltaTime);
    }
}
