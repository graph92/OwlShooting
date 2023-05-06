using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Bullet : MonoBehaviour
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
		if (collider != null && collider.gameObject.GetComponent<Enemy>() != null)
		{
			//gameObject.SetActive(false);
			Destroy(collider.gameObject);
			Destroy(gameObject);
		}

	}
}
