using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
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
        RaycastHit2D top = Physics2D.Raycast(topCast.position, Vector2.up, 1);
        RaycastHit2D bottom = Physics2D.Raycast(bottomCast.position, -Vector2.up, 1);
        RaycastHit2D right = Physics2D.Raycast(rightCast.position, -Vector2.left, 1);
        RaycastHit2D left = Physics2D.Raycast(leftCast.position, Vector2.left, 1);
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

        if (Input.GetKeyDown(KeyCode.W) && !objectTop || Input.GetKeyDown(KeyCode.UpArrow) && !objectTop)
        {
            gameObject.transform.position += new Vector3(0,1,0);
            resetObjects();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && !objectBottom || Input.GetKeyDown(KeyCode.S) && !objectBottom)
        {
            gameObject.transform.position += new Vector3(0, -1, 0);
            resetObjects();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && !objectLeft || Input.GetKeyDown(KeyCode.A) && !objectLeft)
        {
            gameObject.transform.position += new Vector3(-1, 0, 0);
            resetObjects();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && !objectRight || Input.GetKeyDown(KeyCode.D) && !objectRight)
        {
            gameObject.transform.position += new Vector3(1, 0, 0);
            resetObjects();
        }
    }
}
