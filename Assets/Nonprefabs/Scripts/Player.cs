using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float timer = 0;
	public float shotPeriod = 1;
	public GameObject bullet;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		Move();
		CreateBullet();
	}
	void Move()
	{
		float dx = 0, dy = 0;
		if (Input.GetKey(KeyCode.RightArrow))
		{
			dx = 1;
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			dx = -1;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			dy = 1;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			dy = -1;
		}
		transform.Translate(new Vector3(dx, dy, 0f) * 0.01f);
	}
	void CreateBullet()
	{
		timer += Time.deltaTime;
		if (timer > shotPeriod)
		{
			timer = 0;
			if (Input.GetKey(KeyCode.Space))
			{
				GameObject o = Instantiate(bullet, this.transform.position, this.transform.rotation);
				o.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 3.0f);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other != null && other.gameObject.GetComponent<Enemy>() != null)
		{
			gameObject.SetActive(false);
		}


		//if (other != null && other.gameObject.GetComponent<Enemy>() != null)
		//	Destroy(gameObject);
	}
}
