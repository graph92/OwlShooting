using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Enemy : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		
	}

	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider != null && collider.gameObject.GetComponent<Bullet>() == null)
		{

			//collider.gameObject.SetActive(false);
			Destroy(collider.gameObject);
			Destroy(gameObject);
		}

		//if (collision != null)
		//{
		//	collision.gameObject.SetActive(false);
		//}
	}
}
