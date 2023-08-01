using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0,15,0);
        transform.eulerAngles = new Vector3(90, 0, -player.transform.eulerAngles.y);
    }
}
