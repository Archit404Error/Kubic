using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitObstacle : MonoBehaviour
{
    public void OnCollisionEnter(Collision info)
    {
        var player = GameObject.Find("Player");
        if(info.collider.name == "object")
            FindObjectOfType<GameManager>().die();
    }

}
