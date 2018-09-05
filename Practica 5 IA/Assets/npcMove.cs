using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcMove : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	Transform _destination;
	UnityEngine.AI.NavMeshAgent _navMeshAgent;
	void Start () {
		_navMeshAgent = this.GetComponent<UnityEngine.AI.NavMeshAgent> ();
		if (_navMeshAgent == null) {
			Debug.LogError ("El agente de navegacion no esta anadido" + gameObject.name);
		} 
		else 
		{
			SetDestination ();
		}
	}
	private void SetDestination()
	{
		Vector3 targetVector = _destination.transform.position;
		_navMeshAgent.SetDestination (targetVector);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
