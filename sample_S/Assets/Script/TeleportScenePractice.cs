using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportScenePractice : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Practice");
    }
}
