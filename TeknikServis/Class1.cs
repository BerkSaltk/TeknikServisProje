using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{

    class arıza
        // sınıftaki public elemanlara değer atamak ve değerlerini okumak için get set metotları kullanıyorum.
    {
        int _id;
        int _tcno;
        string _ad ;
        string _soyad;
        string _yetki;
        string _kullaniciAdi;
        string _parola;
        string _email;


        // Özellikler (Properties)
        public int Id
        {
            get { return _id; }                // get return değeri gönderir böylelikle geri döndürmeye yarar.
            set { _id = value; }               // set değeri ayarlama işlemini yapar.
        }

        public int tcno
        {
            get { return _tcno; }           // get return değeri gönderir böylelikle geri döndürmeye yarar
            set { _tcno= value; }          // set değeri ayarlama işlemini yapar.
        }

        public string ad
        {
            get { return _ad; }        // get return değeri gönderir böylelikle geri döndürmeye yarar
            set { _ad = value; }       // set değeri ayarlama işlemini yapar.
        }

        public string soyadı
        {
            get { return _soyad; }        // get return değeri gönderir böylelikle geri döndürmeye yarar
            set { _soyad = value; }       // set değeri ayarlama işlemini yapar.
        }

        public string yetki
        {
            get { return _yetki; }         // get return değeri gönderir böylelikle geri döndürmeye yarar
            set { _yetki = value; }        // set değeri ayarlama işlemini yapar.
        }

        public string kullaniciAdi
        {
            get { return _kullaniciAdi; }         // get return değeri gönderir böylelikle geri döndürmeye yarar
            set { _kullaniciAdi = value; }        // set değeri ayarlama işlemini yapar.
        }
        public string parola
        {
            get { return _parola; }         // get return değeri gönderir böylelikle geri döndürmeye yarar
            set { _parola = value; }      // set değeri ayarlama işlemini yapar.
 
        public string eMail
        {
            get { return _email; }         // get return değeri gönderir böylelikle geri döndürmeye yarar
            set { _email = value; }        // set değeri ayarlama işlemini yapar.
        }
    }
}

