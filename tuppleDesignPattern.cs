using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuppleDesignPattern : MonoBehaviour
{
    
    void Start()
    {
        //Tupple Design Pattern switch i�in temiz ve kullan��l� bir yap� sa�l�yor.
        string myName = "Burak Karademir"; //String t�r�nde de�i�kenimi tan�mlad�m.
        int myAge = 22;                    //�nteger t�r�nde de�i�kenimi tan�mlad�m.

        string myMessage = (myName, myAge) switch //Pattern'a tan�mlad���m de�i�kenleri vererek ba�lat�yorum.
        {
            ("Burak Karademir", 22) => myMessage = "isim:" + " " + myName + " " + "ya�:" + " " + myAge, //Kontrol sa�l�yor ve bu sat�rda e�le�iyor.
            ("Burak", 25) => myMessage = "Burak",
            ("Burak KARADEM�R", 22) => myMessage = "Burak KARADEM�R 22",
            (_,_) => "Uyu�muyor"
        };
        Debug.Log(myMessage); //Unity'de console ekran�nda 16. sat�rdaki ��kt�y� al�yoruz.
    }

    
}
