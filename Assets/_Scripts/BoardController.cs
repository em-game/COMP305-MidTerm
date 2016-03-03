using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BoardController : MonoBehaviour {

	// PRIVATE INSTANCE VARIABLES
	private int _scoreValue;
	private int _livesValue;

	// PUBLIC INSTANCE VARIABLES
	public Text LivesLabel;
	public Text ScoreLabel;
	public Text HighScoreLabel;
	public Text GameOverLabel;
	public Button RestartButton;

	// Public Access Methods
	public int ScoreValue
	{
		get
		{
			return this._scoreValue;
		}

		set
		{
			this._scoreValue = value;
			this.ScoreLabel.text = "Score:" + this._scoreValue;
		}
	}

	public int LivesValue
	{
		get
		{
			return this._livesValue;
		}

		set
		{
			this._livesValue = value;
			if (this._livesValue <= 0)				
			{
				
				this._endGame ();	
			}
			else
			{
				this.LivesLabel.text = "Lves:" + this._livesValue;
			}
		}
	}


	//Initial Method
	private void _initialize()
	{
		this.ScoreValue = 0;
		this.LivesValue = 5;
		this.HighScoreLabel.enabled = false;
		this.GameOverLabel.enabled = false;
		this.RestartButton.gameObject.SetActive (false);
	}


	// Use this for initialization
	void Start () {
		this._initialize();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void _endGame(){
		this.HighScoreLabel.text = "High Score : " + this._scoreValue;
		this.LivesLabel.enabled = false;
		this.ScoreLabel.enabled = false;
		this.HighScoreLabel.enabled = true;
		this.GameOverLabel.enabled = true;
		this.RestartButton.gameObject.SetActive (true);
	}

	public void RestartButtonClick(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

}
