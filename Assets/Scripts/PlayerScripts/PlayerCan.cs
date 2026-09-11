using UnityEngine;
using UnityEngine.UI;

public class PlayerCan : MonoBehaviour
{
    public static PlayerCan instance;

    [SerializeField] int maxSaglik = 10;
    int gecerliSaglik;

    [SerializeField] Image healthFill;


    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        gecerliSaglik = maxSaglik;
        HealthBarUpdate();
    }

    public void hasarAl(int hasarMiktari) 
    {
        gecerliSaglik -= hasarMiktari;

        gecerliSaglik=Mathf.Clamp(gecerliSaglik, 0, maxSaglik);

        HealthBarUpdate();

        if( gecerliSaglik <= 0)
        {
            uiManager.instance.GameOverPAneliAc();
            gameObject.SetActive(false);
        }
    }



    void HealthBarUpdate()
    {
        float canMiktari=(float)gecerliSaglik/maxSaglik;
        healthFill.fillAmount = canMiktari;
    }
}
