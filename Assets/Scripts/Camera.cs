using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Vector3 distance;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + distance;
    }
}
