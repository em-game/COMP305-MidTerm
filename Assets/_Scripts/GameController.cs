using UnityEngine;
using System.Collections;


public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int tankCount;
	public GameObject tank;
	public float speed = 5f;
	public BoardController boardController;

	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		this._GenerateTanks ();
		this._transform = gameObject.GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update () {
		

	}

	// generate Clouds
	private void _GenerateTanks() {
		for (int count=0; count < this.tankCount; count++) {
			Instantiate(tank);
		}
	}





}
