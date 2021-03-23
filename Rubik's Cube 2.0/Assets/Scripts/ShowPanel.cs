using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanel : MonoBehaviour
{
    public GameObject Panel;

    public void PointerEnter()
    {
        Panel.gameObject.SetActive(true);
    }

    public void PointerExit()
    {
        Panel.gameObject.SetActive(false);
    }
}