using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
	private Animator animator;
	private AudioSource audioSource;

	public bool isGet;

    // Start is called before the first frame update
    void Start()
	{
		animator = gameObject.GetComponent<Animator>();
		audioSource = gameObject.GetComponent<AudioSource>();

		isGet = false;
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

		isGet = true;
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
