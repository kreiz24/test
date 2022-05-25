using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManeger : MonoBehaviour
{
    public static EventManeger Instance;
	[Header("Player and Enemy Properties")]				
	public GameObject CarecterPlayer;	
    public Transform EnemyTarget;	

    public PlayerControler Controller;
    	void Awake()
	{
		
		if (Instance == null)
			Instance = this;
		else if (Instance != this)
			Destroy(this);
	}
    public void PlayerChosen(PlayerControler selected)
	{
			Controller = selected;
		UnSummonAlly();
	}
    void ReloadScene()
	{
		//Получить ссылку на текущую сцену
		Scene currentScene = SceneManager.GetActiveScene();
		// Сообщаем диспетчеру сцен, что нужно загрузить текущую сцену (которая перезагружает ее)
		SceneManager.LoadScene(currentScene.buildIndex);
		
	}
	void UnSummonAlly()
	{
		//Враги начинают погоню за игроком
		EnemyTarget = Controller.transform;
	}
}
