using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MTZ_Start_Script : MonoBehaviour
{
    // Start is called before the first frame update
    

public class SceneChanger : MonoBehaviour
{
	public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene(name);
	}
	public void Exit()
	{
		Application.Quit();
	}
}
}
