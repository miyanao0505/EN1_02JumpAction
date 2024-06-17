using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
	private Animator animator;
	private AudioSource audioSource;

	// Start is called before the first frame update
	void Start()
	{
		animator = GetComponent<Animator>();
		audioSource = GetComponent<AudioSource>();
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
		// 接触した瞬間に呼ばれる
		animator.SetTrigger("Get");
		audioSource.Play();
	}

	private void OnTriggerStay(Collider other)
	{
		// 接触している間に呼ばれる
	}

	private void OnTriggerExit(Collider other)
	{
		// 離れた時に呼ばれる
	}
}
