using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetSave : MonoBehaviour
{
public void ResetSave()
    {
        PlayerPrefs.DeleteAll();
    }
}
