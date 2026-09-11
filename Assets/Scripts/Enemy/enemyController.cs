using UnityEngine;

public class enemyController : MonoBehaviour
{
    public Transform[] hedefler;
    public float hareketHizi = 3f;

    int mevcutHedefIndex = 0;

    public int hasarMiktari = 3;

    private void Update()
    {

        if (hedefler.Length == 0) return;

        transform.position = Vector3.MoveTowards(transform.position, hedefler[mevcutHedefIndex].position,hareketHizi*Time.deltaTime);

        if (Vector3.Distance(transform.position, hedefler[mevcutHedefIndex].position) < 0.1f)
        {
            mevcutHedefIndex++;

            if(mevcutHedefIndex >= hedefler.Length)
            {
                mevcutHedefIndex = 0;
                transform.position = hedefler[mevcutHedefIndex].position;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PlayerBullet"))
        {   
            GameManager.instance.DusmanYokEt(this.gameObject);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }

        if (other.gameObject.CompareTag("Player"))
        {
            PlayerCan.instance.hasarAl(hasarMiktari);
            Destroy(this.gameObject);
        }
    }


}
