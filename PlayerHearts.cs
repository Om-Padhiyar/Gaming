using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHearts : MonoBehaviour
{
   public int health = 3;
   public int numOfHearts;
   public Image[] hearts;
   public Sprite fullHeart;
   public Sprite emptyHeart;

void Awake(){
    health = 3;
}
 public void SetHealth(int num){
    health = num;

}
    void Update(){
        for(int i = 0; i < hearts.Length; i++){
            
if(health > numOfHearts){
    health = numOfHearts;
        }

            if(i < health){
                hearts[i].sprite = fullHeart;
            }
            else{
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts){
                hearts[i].enabled = true;
            }
            else{
                hearts[i].enabled = false;
            }
        }
    }

}
