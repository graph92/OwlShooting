using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
	public GameObject enemySample;
	float timer = 0;
	public float enemyCreatePeriod = 1;
	// Start is called before the first frame update
	void Start()
	{
		var gameObjectList = GameObject.FindObjectsOfType<GameObject>();
		foreach (var gameObject in gameObjectList)
		{
			if (gameObject.GetComponent<Camera>() == null)
				gameObject.AddComponent<CommonScript>();
			//if(gameObject)
		}
	}

	// Update is called once per frame
	void Update()
	{
		timer += Time.deltaTime;
		if (timer > enemyCreatePeriod)
		{
			timer = 0;
			var mainCamera = Camera.main;
			var viewportRect = mainCamera.rect;

			Vector3 min = mainCamera.ViewportToWorldPoint(new Vector3(viewportRect.xMin, viewportRect.yMin, 0));
			Vector3 max = mainCamera.ViewportToWorldPoint(new Vector3(viewportRect.xMax, viewportRect.yMax, 0));
			float x = Random.Range(min.x, max.x);
			float y = Random.Range(min.y + (max.y - min.y) * 2 / 3, max.y);

			GameObject o = Instantiate(enemySample, new Vector3(x, y, 0), this.transform.rotation);
			o.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1.0f);
		}
	}
}
