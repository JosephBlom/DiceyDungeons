using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] Transform topCast;
    [SerializeField] Transform bottomCast;
    [SerializeField] Transform leftCast;
    [SerializeField] Transform rightCast;
    bool objectLeft = false;
    bool objectRight = false;
    bool objectTop = false;
    bool objectBottom = false;
    void Start()
    {
        
    }

    void Update()
    {
        casting();
        playerMove(); 
    }
    void resetObjects()
    {
        objectLeft = false;
        objectRight = false;
        objectTop = false;
        objectBottom = false;
    }
    void casting()
    {
        RaycastHit2D top = Physics2D.Raycast(topCast.position, new Vector2(0.5f, 0.24f), 0.5f);
        RaycastHit2D bottom = Physics2D.Raycast(bottomCast.position, new Vector2(-0.5f, -0.24f), 1);
        RaycastHit2D right = Physics2D.Raycast(rightCast.position, new Vector2(0.5f, -0.24f), 1);
        RaycastHit2D left = Physics2D.Raycast(leftCast.position, new Vector2(-0.5f, 0.24f), 1);
        if (left.collider != null)
        {
            if (left.collider.CompareTag("Enemy"))
            {
                objectLeft = true;
            }
            else
            {
                objectLeft = false;
            }
        }
        if (right.collider != null)
        {
            if (right.collider.CompareTag("Enemy"))
            {
                objectRight = true;
            }
            else
            {
                objectRight = false;
            }
        }
        if (top.collider != null)
        {
            if (top.collider.CompareTag("Enemy"))
            {
                objectTop = true;
            }
            else
            {
                objectTop = false;
            }
        }
        if (bottom.collider != null)
        {
            if (bottom.collider.CompareTag("Enemy"))
            {
                objectBottom = true;
            }
            else
            {
                objectBottom = false;
            }
        }


    }
    void playerMove()
    {

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (!objectTop)
            {
                gameObject.transform.position += new Vector3(0.5f, 0.24f, 0);
                resetObjects();
            }
            else
            {
                gameManager.activateDuelCanvas();
            }
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (!objectBottom)
            {
                gameObject.transform.position += new Vector3(-0.5f, -0.24f, 0);
                resetObjects();
            }
            else
            {
                gameManager.activateDuelCanvas();
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.A))
        {
            if (!objectLeft)
            {
                gameObject.transform.position += new Vector3(-0.5f, 0.24f, 0);
                resetObjects();
            }
            else
            {
                gameManager.activateDuelCanvas();
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)|| Input.GetKeyDown(KeyCode.D))
        {

            if(!objectRight)
            {
                gameObject.transform.position += new Vector3(0.5f, -0.24f, 0);
                resetObjects();
            }
            else
            {
                gameManager.activateDuelCanvas();
            }
        }
    }
}
