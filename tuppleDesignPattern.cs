using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuppleDesignPattern : MonoBehaviour
{
    
    void Start()
    {
        //Tupple Design Pattern switch için temiz ve kullanýþlý bir yapý saðlýyor.
        string myName = "Burak Karademir"; //String türünde deðiþkenimi tanýmladým.
        int myAge = 22;                    //Ýnteger türünde deðiþkenimi tanýmladým.

        string myMessage = (myName, myAge) switch //Pattern'a tanýmladýðým deðiþkenleri vererek baþlatýyorum.
        {
            ("Burak Karademir", 22) => myMessage = "isim:" + " " + myName + " " + "yaþ:" + " " + myAge, //Kontrol saðlýyor ve bu satýrda eþleþiyor.
            ("Burak", 25) => myMessage = "Burak",
            ("Burak KARADEMÝR", 22) => myMessage = "Burak KARADEMÝR 22",
            (_,_) => "Uyuþmuyor"
        };
        Debug.Log(myMessage); //Unity'de console ekranýnda 16. satýrdaki çýktýyý alýyoruz.
    }

    
}
