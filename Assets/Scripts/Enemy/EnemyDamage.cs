using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int hasarMiktari = 2;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            PlayerCan.instance.hasarAl(hasarMiktari);

            Destroy(gameObject);
        }
    }
}
