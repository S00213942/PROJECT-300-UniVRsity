﻿namespace TurnTheGameOn.NPCChat
{
	using UnityEngine;

	public class DestroyAudioSource : MonoBehaviour
	{
		private AudioSource audioSource;

		void Start()
		{
			audioSource = GetComponent<AudioSource>();
		}

		void Update()
		{
			if (audioSource.isPlaying == false)
			{
				Destroy(gameObject);
			}
		}
	}
}