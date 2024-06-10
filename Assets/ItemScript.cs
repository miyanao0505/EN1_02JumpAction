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
		// ÚG‚µ‚½uŠÔ‚ÉŒÄ‚Î‚ê‚é
		animator.SetTrigger("Get");
	}

	private void OnTriggerStay(Collider other)
	{
		// ÚG‚µ‚Ä‚¢‚éŠÔ‚ÉŒÄ‚Î‚ê‚é
	}

	private void OnTriggerExit(Collider other)
	{
		// —£‚ê‚½‚ÉŒÄ‚Î‚ê‚é
	}
}
