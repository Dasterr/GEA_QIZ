using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControllerScript : MonoBehaviour {

    public float speed = 10.0f;
    private Vector3 pos;
    private Transform tr;
    private bool collided = false;
    private string lastKeyPressed = "";

	// Use this for initialization
	void Start () {
        pos = transform.position;
        tr = transform;
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 raycastDir = new Vector3();
        if (Input.GetKeyDown(KeyCode.W)){
            lastKeyPressed = "up";
            raycastDir = Vector3.up;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            lastKeyPressed = "right";
            raycastDir = Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            lastKeyPressed = "down";
            raycastDir = Vector3.down;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            lastKeyPressed = "left";
            raycastDir = Vector3.left;
        }
        RaycastHit2D hit = Physics2D.Raycast(pos, raycastDir, 1);
        if (hit)
            if (hit.collider.tag == "Edge")
                lastKeyPressed = "";
        
        if (lastKeyPressed == "up")
            pos += Vector3.up;
        else if (lastKeyPressed == "right")
            pos += Vector3.right;
        else if (lastKeyPressed == "down")
            pos += Vector3.down;
        else if (lastKeyPressed == "left")
            pos += Vector3.left;
        
        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
        collided = false;
    }
}

/*

public bool Mover_Arriva; public bool Mover_Abajo; public bool Mover_Derecha; public bool Mover_Izquierda;


public Cuerpo primer_cuerpo;


public float Tiempo_movimiento = .5F; public float Siguiente_movimiento;


// Use this for initialization 
public bool Mover_Arriva; public bool Mover_Abajo; public bool Mover_Derecha; public bool Mover_Izquierda;
public Cuerpo primer_cuerpo;
public float Tiempo_movimiento = .5F;
public float Siguiente_movimiento;

void Start () {
    Mover_Arriva = false;
    Mover_Abajo = false;
    Mover_Derecha = false;
    Mover_Izquierda = false;
    Siguiente_movimiento = Time.time + Tiempo_movimiento;
} // Update is called once per frame 
void Update()
{
    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
        Mover_Arriva = true;
        Mover_Abajo = false;
        Mover_Derecha = false;
        Mover_Izquierda = false;
    }
    if (Input.GetKeyDown(KeyCode.DownArrow))
    {
        Mover_Arriva = false;
        Mover_Abajo = true;
        Mover_Derecha = false;
        Mover_Izquierda = false;
    }
    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
        Mover_Arriva = false;
        Mover_Abajo = false;
        Mover_Derecha = true;
        Mover_Izquierda = false;
    }
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
        Mover_Arriva = false;
        Mover_Abajo = false;
        Mover_Derecha = false;
        Mover_Izquierda = true;
    }

    if (Time.time &gt; Siguiente_movimiento)
    {
        MoverCabeza();
    }
}

void MoverCabeza() {
    if (Mover_Arriva) {
        primer_cuerpo.mover(this.transform);
        this.transform.position += transform.forward transform.localScale.z;
    }
    if (Mover_Abajo) {
        primer_cuerpo.mover(this.transform);
        this.transform.position += -transform.forward  transform.localScale.z;
    }
    if (Mover_Derecha) {
        primer_cuerpo.mover(this.transform);
        this.transform.position += transform.right  transform.localScale.z;
    }
    if (Mover_Izquierda) {
        primer_cuerpo.mover(this.transform);
        this.transform.position += -transform.right  transform.localScale.z;
    }
    Siguiente_movimiento = Time.time + Tiempo_movimiento; } 
} 
*/