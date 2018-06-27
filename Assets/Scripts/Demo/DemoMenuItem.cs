﻿using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Demo
{
	public class DemoMenuItem : MonoBehaviour
	{
		[SerializeField]
		protected string sceneName;

		public void Clicked()
		{
			SceneManager.LoadScene(sceneName);
		}
	}
}