using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class LinkMAnager : MonoBehaviour
{
    public void openLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/tanish-ahmed/");
    }
    public void openGitHub()
    {
        Application.OpenURL("https://github.com/Tanish-Ahmed");
   }
}
