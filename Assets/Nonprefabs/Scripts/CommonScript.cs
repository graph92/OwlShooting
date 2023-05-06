using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

//public class MyGameObjectPart
//{
//	protected CommonScript myGameObjectScript;
//	public MyGameObjectPart()
//	{

//	}
//	public MyGameObjectPart(CommonScript gameObjectScript)
//	{
//		myGameObjectScript = gameObjectScript;
//	}
//	public virtual void ActionOnInput()
//	{

//	}
//	//public abstract void ActionOnKey(GameObject gameObject);
//}

//public class ExamObjectPart : MyGameObjectPart
//{
//	public ExamObjectPart()
//	{
//	}
//	public ExamObjectPart(CommonScript myGameObjectScript)
//	{
//		this.myGameObjectScript = myGameObjectScript;
//	}
//	public override void ActionOnInput()
//	{
		
//	}
//}

public class CommonScript : MonoBehaviour
{
	//MyGameObjectPart myGameObject;
	// Start is called before the first frame update
	void Start()
	{
		//myGameObject = new ExamObjectPart(this);
	}

	// Update is called once per frame
	void Update()
	{
		//myGameObject.ActionOnInput();
	}
}
