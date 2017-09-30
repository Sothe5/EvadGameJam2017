using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefManager : MonoBehaviour {

	private static string DIFFICULTY = "Difficulty";



	public void SetDifficulty(int amount){
		PlayerPrefs.SetInt (DIFFICULTY, amount);
	}

	public int getDifficulty(){
		return PlayerPrefs.GetInt (DIFFICULTY);
	}

}
