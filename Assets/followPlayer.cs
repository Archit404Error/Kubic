using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform cameraPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var player = GameObject.Find("Player");

        cameraPos.position = player.GetComponent<Transform>().position + new Vector3(0,2, -10);
    }
}