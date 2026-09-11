using UnityEngine;

public class PlayerHareketManager : MonoBehaviour
{
    [Header("Elementler")]
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform MermiSpawn;

    [Header("Ayarlar")]
    [SerializeField] float moveSpeed = 8f;
    [SerializeField] float minX = -4;
    [SerializeField] float maxX = 4;
    [SerializeField] float minY = -2;
    [SerializeField] float maxY = 2;
    private void Update()
    {
        PlayerHareketFNC();

        if (Input.GetMouseButtonDown(0))
        {
            MermiFirlatFNC();
        }

       
    }

    private void PlayerHareketFNC()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 hareketVektor = new Vector3(h, v, 0);
        hareketVektor = hareketVektor.normalized;
        transform.Translate(hareketVektor * moveSpeed * Time.deltaTime);

        Vector3 clampPosition = transform.position;
        clampPosition.x = Mathf.Clamp(clampPosition.x, minX, maxX);
        clampPosition.y = Mathf.Clamp(clampPosition.y, minY, maxY);

        transform.position = clampPosition;
    }

    void MermiFirlatFNC()
    {
        Instantiate(bulletPrefab,MermiSpawn.position,Quaternion.identity);
    }
}
