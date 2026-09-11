
using UnityEngine;

public class BackroundLoop : MonoBehaviour
{
    [SerializeField] float yukseklik;

    private void Update()
    {
        if(transform.position.y< -yukseklik)
        {
            PozisyonuGuncelle();
        }
    }

    private void PozisyonuGuncelle()
    {
        Vector3 pos = new Vector3(0, yukseklik * 2);
        transform.position =transform.position + pos;
    }
}
