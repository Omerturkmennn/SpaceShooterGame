using System.Collections;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour
{
    [Header("Ayarlar")]
    [SerializeField] float minX = -3f;
    [SerializeField] float maxX = 3f;
    [SerializeField] float sabitY = 12f;
    [SerializeField] float firlatmaSuresi = 5f;

    [Header("Elementler")]
    [SerializeField] GameObject[] gezegenPrefabs;

    private void Start()
    {
        StartCoroutine(GezegenFirlatFNC());
    }

    IEnumerator GezegenFirlatFNC()
    {
        while (true)
        {
            float rastgeleX=Random.Range(minX, maxX);
            
            Vector3 firlatmaPos=new Vector3(rastgeleX,sabitY,0);

            int rastgeleIndex=Random.Range(0,gezegenPrefabs.Length);
            GameObject gezegenPrefab= Instantiate(gezegenPrefabs[rastgeleIndex], firlatmaPos, Quaternion.identity);
            Destroy(gezegenPrefab,30 );
            yield return new WaitForSeconds(firlatmaSuresi);
        }
    } 
}
