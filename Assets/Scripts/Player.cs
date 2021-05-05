using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float gravity;
    public GameObject warp1, warp2, warp3;
    public GameObject camera;

    private Rigidbody rb;
    private LevelManager lm;

    void Awake()
    {
        lm = GameObject.Find("LevelManager").GetComponent<LevelManager>();

        if (lm.stage == 1)
        {
            this.transform.position = warp1.transform.position;
            
        }
        else if (lm.stage == 2)
        {
            this.transform.position = warp2.transform.position;
        }
        else if (lm.stage == 3)
        {
            this.transform.position = warp3.transform.position;
        }

        camera.transform.position = this.transform.position - new Vector3(0f, 0f, 20);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(moveHorizontal * speed, moveVertical * speed, gravity));


    }
}
