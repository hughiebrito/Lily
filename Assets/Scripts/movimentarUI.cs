using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movimentarUI : MonoBehaviour {
	public Image barco;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MoverUI();
	}
    public void MoverUI()
    {
		barco.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
    }
}
