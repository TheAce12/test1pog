using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;

namespace Scenes
{
    public class scenechanger : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            SceneManager.LoadScene(1);
        }
    }
}