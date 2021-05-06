using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public float gravity;
    public GameObject warp1, warp2, warp3;
    public GameObject camera;
    public GameObject clear;

    private Rigidbody rb;
    private LevelManager lm;
	
	public int segundos;
    public int minutos;
	public float timer;
	public float velocidadeRb;
	public Text tempo;
	public Text velocidade;
    public Text tempoClear;
    public Text velocidadeClear;

    void Awake()
    {
        
        clear.SetActive(false);
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
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
		if (timer >= 1)
		{
			segundos++;
            
            if (segundos >= 60)
            {
				segundos = 0;
                minutos++;
            }
			timer = 0;
		}
           
        tempo.text = "Tempo: "+minutos+":"+segundos;
		velocidade.text = "Velocidade: "+velocidadeRb.ToString("F") + " km/h";
        
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(moveHorizontal * speed, moveVertical * speed, gravity));
		
		velocidadeRb = GetComponent<Rigidbody>().velocity.z;

    }
	
	private void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.CompareTag("Earth"))
		{
			Debug.Log("Explode tudo");
            tempoClear.text = tempo.text;
            velocidadeClear.text = velocidade.text;
            Time.timeScale = 0;
            clear.SetActive(true);
        }
	}
}
