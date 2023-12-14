using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToDuel : MonoBehaviour
{
    [SerializeField] SceneLoader loader;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void duel()
    {
        loader.LoadButton("DuelScene");
    }
}
