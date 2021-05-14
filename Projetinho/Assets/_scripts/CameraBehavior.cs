using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    private Vector3 camPosition;
    public GameObject player;
    private Vector3 playerPosition;
    void Start()
    {
       playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
