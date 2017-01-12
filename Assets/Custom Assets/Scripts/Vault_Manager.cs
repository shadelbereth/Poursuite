using UnityEngine;
using System.Collections;

public class Vault_Manager : MonoBehaviour {

    public int Number;

	// Use this for initialization
	void Start () {
	   Number = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {
        Number ++;
        if (Number > 3) {
            print("YOU'RE A WINNER AND YOU KNOW IT");
        }
    }
}
