using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
	public string nextSceneName;
	public string nowSceneName;
	public bool isClear;

	// �t�B�[���h
	List<GameObject> itemes;

	// �I�u�W�F�N�g
	public GameObject ItemPrefab;

	// �e�L�X�g�I�u�W�F�N�g
	public GameObject clearText;

	bool IsCleard()
	{
		if(ItemPrefab.GetComponent<ItemScript>().isGet)
		{
			clearText.SetActive(true);

			return true;
		}
		return false;
	}

	// Start is called before the first frame update
	void Start()
	{
		isClear = false;
	}

	// Update is called once per frame
	void Update()
	{
		if(nowSceneName == "TitleScene" || nowSceneName == "GameClearScene")
		{
			if(Input.GetKeyUp(KeyCode.Space))
			{
				SceneManager.LoadScene(nextSceneName);
			}
		}
		else
		{
			if (isClear)
			{
				if (Input.GetKeyUp(KeyCode.Space))
				{
					clearText.SetActive(false);

					SceneManager.LoadScene(nextSceneName);
				}
			}
			else
			{
				isClear = IsCleard();
			}
		}

		//Esc�������ꂽ��
		if (Input.GetKey(KeyCode.Escape))
		{

#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;        //�Q�[���v���C�I��
#else
			Application.Quit();										//�Q�[���v���C�I��
#endif
		}
	}
}
