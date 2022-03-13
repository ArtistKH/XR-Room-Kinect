using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectBtngana : MonoBehaviour
{
    public List<GameObject> hamada;
    public GameObject currentHamada;
    public int currentIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O)){
            ChangeHamada(1);
        }
        if(Input.GetKeyDown(KeyCode.P)){
            ChangeHamada(-1);
        }
    }

    public void ChangeHamada(int hamadaIndex){
        currentIndex+=hamadaIndex;
            if(currentIndex >hamada.Count){
            currentIndex =0;
            }
            if(currentIndex<0){
                currentIndex=hamada.Count;
            }
            DestoryEffect();
            CreateEffect();
    }

    public void CreateEffect(){
    currentHamada = Instantiate(hamada[currentIndex],this.transform);
    }
    public void DestoryEffect(){
        Destroy(currentHamada);
    }
}
