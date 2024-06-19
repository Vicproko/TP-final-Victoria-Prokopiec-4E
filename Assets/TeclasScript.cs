using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeclasScript : MonoBehaviour
{

    public GameObject[] ListaModelos3d;
    public int Indice = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < ListaModelos3d.Length; i++)
        {
            ListaModelos3d[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !Input.GetKeyDown(KeyCode.RightArrow))
        {
            ListaModelos3d[Indice].SetActive(false);
            Indice++;

            if (Indice == ListaModelos3d.Length)
            {
                Indice = 0;
            }

            ListaModelos3d[Indice].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && !Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ListaModelos3d[Indice].SetActive(false);
            Indice--;

            if (Indice == -1)
            {
                Indice = ListaModelos3d.Length-1;
            }
        }

        ListaModelos3d[Indice].SetActive(true);
    }

}
