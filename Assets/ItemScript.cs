using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
	private Animator animator;

	// Start is called before the first frame update
	void Start()
	{
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	private void DestroySelf()
	{
		Destroy(gameObject);
	}

	private void OnTriggerEnter(Collider other)
	{
		// �ڐG�����u�ԂɌĂ΂��
		//DestroySelf();
		animator.SetTrigger("Get");
	}

	private void OnTriggerStay(Collider other)
	{
		// �ڐG���Ă���ԂɌĂ΂��
		Debug.Log("Stay");
	}

	private void OnTriggerExit(Collider other)
	{
		// ���ꂽ���ɌĂ΂��
		Debug.Log("Exit");
	}
}
