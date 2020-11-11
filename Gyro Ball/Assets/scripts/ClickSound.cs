using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
   public void ClickingSound()
    {
        FindObjectOfType<AudioManager>().PlaySound("Click");
    }
}
