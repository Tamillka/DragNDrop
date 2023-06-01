using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinasParslegt : MonoBehaviour {

    public void uzSakumu()
    {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }
    public void apturet()
    {
        Application.Quit();
    }
    public void uzPilsetu()
    {
        SceneManager.LoadScene("PilsetasAina", LoadSceneMode.Single);
    }
}
