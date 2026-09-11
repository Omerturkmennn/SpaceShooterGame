using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float mermiHiz = 10f;
    [SerializeField] GameObject effect;

    private void Update()
    {
        transform.Translate(Vector3.up*mermiHiz*Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other) //carpýsma olunca nesneyý yok et
    {
        if (other.gameObject.CompareTag("Meteor")) 
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(gameObject);   
        }
      
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject);  //mermi kamera dýþýna cýkýnca yok et

    }

}

