using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] float speed;

    private void Update()
    {
        transform.Translate(Vector3.up*speed*Time.deltaTime);
    }



}
