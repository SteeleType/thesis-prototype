using UnityEngine;
using UnityEngine.UI;

public class DeckManager : MonoBehaviour
{
    public Image cardSprite;
    public Sprite[] sprites;
    public int curredntIndex = 0;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (sprites.Length > 0 && cardSprite != null)
        {
            cardSprite.sprite = sprites[curredntIndex];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            curredntIndex++;
            if (curredntIndex >= sprites.Length)
            {
                curredntIndex = 0;
            }
            cardSprite.sprite = sprites[curredntIndex];
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            curredntIndex--;
            if (curredntIndex < 0)
            {
                curredntIndex = sprites.Length - 1;
            }
            cardSprite.sprite = sprites[curredntIndex];
        }
    }
}
