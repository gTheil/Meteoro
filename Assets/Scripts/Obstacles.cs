using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
	public float speed;
    public float facing; //define a direção do X, trocando o valor de movimento para positivo ou negativo

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(gameObject.CompareTag("Rock") || gameObject.CompareTag("Earth") || gameObject.CompareTag("Planet"))
		{
			transform.Rotate(new Vector3(15, 30, 45)* Time.deltaTime * speed);
		}
		
		//horizontal
		if(gameObject.CompareTag("ShipH") || gameObject.CompareTag("AstronautH"))
		{
			transform.position = transform.position + new Vector3((1f * facing) * speed * Time.deltaTime, 0.0f, 0.0f);

			LayerMask mask1 = LayerMask.GetMask("Wall"); //cria uma mask na camada Parede aplicada às paredes
			LayerMask mask2 = LayerMask.GetMask("Planet");
			if (Physics.Raycast(transform.position, Vector3.right, .5f, mask1) || Physics.Raycast(transform.position, Vector3.right, .5f, mask2))
			{
				facing = -1; //trocando de direção
			}
			else if (Physics.Raycast(transform.position, Vector3.left, .5f, mask1) || Physics.Raycast(transform.position, Vector3.left, .5f, mask2))
			{
				facing = 1;
			}
		}
		
		//vertical
		if(gameObject.CompareTag("ShipV") || gameObject.CompareTag("AstronautV"))
		{
			transform.position = transform.position + new Vector3(0.0f, (1f * facing) * speed * Time.deltaTime, 0.0f);

			LayerMask mask1 = LayerMask.GetMask("Wall"); //cria uma mask na camada Parede aplicada às paredes
			LayerMask mask2 = LayerMask.GetMask("Planet");
			
			if (Physics.Raycast(transform.position, Vector3.up, .5f, mask1) || Physics.Raycast(transform.position, Vector3.up, .5f, mask2))
			{
				facing = -1; //trocando de direção
			}
			else if (Physics.Raycast(transform.position, Vector3.down, .5f, mask1) || Physics.Raycast(transform.position, Vector3.down, .5f, mask2))
			{
				facing = 1;
			}
		}
        
    }
}
