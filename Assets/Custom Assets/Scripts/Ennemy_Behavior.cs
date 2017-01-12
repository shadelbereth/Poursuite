using UnityEngine;
using System.Collections;

public class Ennemy_Behavior : MonoBehaviour {

public GameObject Target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	   GetComponent<NavMeshAgent>().destination = Target.transform.position;
	}

    void OnTriggerEnter(Collider Other) {
        print("CRUSHED !!!");
    }
}
