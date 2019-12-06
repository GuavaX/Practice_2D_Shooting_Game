using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習

    [Header("血量")]
    public int hp = 10;

    [Header("血量介面")]
    public Text textHp;

    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip soundHit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.name);
        if(collision.name == "子彈(Clone)")
        {
            aud.PlayOneShot(soundHit, 2f);
            hp -= 1;
            textHp.text = hp.ToString();
        }

        if (hp <= 0)
        {
            print("RRRRRRRRRRRRRRRRRRR");
            Destroy(gameObject, 0.1f);
        }
    }


    #endregion
}
