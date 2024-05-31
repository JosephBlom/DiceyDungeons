using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] Transform topCast;
    [SerializeField] Transform bottomCast;
    [SerializeField] Transform leftCast;
    [SerializeField] Transform rightCast;
    public Camera cameraMain;
    public bool isTurn;
    public int usedMoves;

    public Player player;

    bool objectLeft = false;
    bool objectRight = false;
    bool objectTop = false;
    bool objectBottom = false;

    private void Start()
    {
        player = GetComponent<Player>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        cameraMain = Camera.main;
    }

    void Update()
    {
        
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name != "DuelScene")
        {
            casting();
            playerMove();
        }
        
    }

    public void followCamera()
    {
        cameraMain.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -10);
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
        RaycastHit2D top = Physics2D.Raycast(topCast.position, new Vector2(0.5f, 0.25f), 0.5f);
        RaycastHit2D bottom = Physics2D.Raycast(bottomCast.position, new Vector2(-0.5f, -0.25f), 1);
        RaycastHit2D right = Physics2D.Raycast(rightCast.position, new Vector2(0.5f, -0.25f), 1);
        RaycastHit2D left = Physics2D.Raycast(leftCast.position, new Vector2(-0.5f, 0.25f), 1);
        if (left.collider != null)
        {
            if (left.collider.CompareTag("Player"))
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
            if (right.collider.CompareTag("Player"))
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
            if (top.collider.CompareTag("Player"))
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
            if (bottom.collider.CompareTag("Player"))
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
        if (isTurn)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (!objectTop)
                {
                    usedMoves++;
                    if (usedMoves <= player.movesPerTurn)
                    {
                        gameObject.transform.position += new Vector3(0.5f, 0.25f, 0);
                        followCamera();
                        resetObjects();
                    }
                    
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
                    usedMoves++;
                    if(usedMoves <= player.movesPerTurn)
                    {
                        gameObject.transform.position += new Vector3(-0.5f, -0.25f, 0);
                        followCamera();
                        resetObjects();
                    }
                    
                }
                else
                {
                    gameManager.activateDuelCanvas();
                }
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                if (!objectLeft)
                {
                    usedMoves++;
                    if (usedMoves <= player.movesPerTurn)
                    {
                        gameObject.transform.position += new Vector3(-0.5f, 0.25f, 0);
                        followCamera();
                        resetObjects();
                    }
                    
                }
                else
                {
                    gameManager.activateDuelCanvas();
                }
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {

                if (!objectRight)
                {
                    usedMoves++;
                    if (usedMoves <= player.movesPerTurn)
                    {
                        gameObject.transform.position += new Vector3(0.5f, -0.25f, 0);
                        followCamera();
                        resetObjects();
                    }
                    
                }
                else
                {
                    gameManager.activateDuelCanvas();
                }
            }
        }
    }
        
}
