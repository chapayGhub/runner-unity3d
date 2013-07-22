using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{	
	public bool IsPaused { private set; get; }

	public bool IsGameOver { private set; get; }

	public void Resume()
	{
		IsPaused = false;
		Time.timeScale = 1.0f;
	}
	
	public void Pause()
	{
		IsPaused = true;
		Time.timeScale = 0.0f;
	}

	public void GameOver()
	{
		IsGameOver = true;
		Time.timeScale = 0.0f;
	}

	public void StartGame()
	{
		IsGameOver = false;
		Time.timeScale = 1.0f;
	}

	public Player Player
	{
		get { return FindObjectOfType(typeof (Player)) as Player; }
	}
	
	public GameObject[] Coins
	{
		get { return GameObject.FindGameObjectsWithTag(Tags.Coin); }
	}
	
	public GameObject[] Obstacles
	{
		get { return GameObject.FindGameObjectsWithTag(Tags.Obstacle); }
	}

	protected static GameManager instance;
	
	public static GameManager Instance {
		get {
			if(instance == null) {
				instance = (GameManager)FindObjectOfType(typeof(GameManager));
			}	
			return instance;
		}
	}
}
	
