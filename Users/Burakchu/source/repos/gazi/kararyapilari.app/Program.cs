using system.componentmodel.design;

namespace kararyapilari.app
{
    internal class program
    {
        static void main(string[] args)
        {
            console.writeline("burak");

            int sayi1 = 10;
            int sayi2 = 20;

            if (sayi1 > sayi2)
            {
                console.writeline("sayı bir büyüktür");

            }
            else if (sayi2 > sayi1)
            {
                console.writeline("sayı 2 büyüktür");
            }

            else

            {
                console.writeline("sayılar eşittir");
            }


            console.writeline("bir sayı giriniz");
            double sayi1 = int.parse(console.readline());
            console.writeline("bir sayı daha giriniz");
            double sayi2 = int.parse(console.readline());
            console.writeline("yapmak istediğiniz işlemi seçiniz + - * /");
            char islem = char.parse(console.readline());

            string msg = "işlemin sonucu"
            if (islem == '+')
            {
                console.writeline($"{msg} {sayi1 + sayi2} ");
            }
            else if (islem == '-')
            {
                console.writeline($"{msg}{sayi1 - sayi2}");
            }
            else if (islem == '*')
            {
                console.writeline($"{msg} {sayi1 * sayi2} ");
            }
            else if (islem == '/')
            {
                console.writeline($"{msg} {sayi1 / sayi2} ");

            }
            string msg1, msg2, msg3, msg4;
            console.writeline("dil seçiniz / select language ");

            string cevap = console.readline();
            if (cevap == "tr")
                msg1 = "bir sayı giriniz";
            msg2 = "bir sayı daha girniz";
            msg3 = "işlem seçiniz";
            msg4 = "işlemin sonucu";

             else
                msg1 = "enter first number";
            msg2 = "enter second number";
            msg3 = "select operation";
            msg4 = "result";


            console.writeline(msg1);
            double sayi1 = int.parse(console.readline());
            console.writeline(msg2);
            double sayi2 = int.parse(console.readline());
            console.writeline(msg3);
            char islem = char.parse(console.readline());
            console.writeline(msg4);

            if (islem == '+')
            {
                console.writeline($"{msg4} {sayi1 + sayi2} ");
            }
            else if (islem == '-')
            {
                console.writeline($"{msg4}{sayi1 - sayi2}");
            }
            else if (islem == '*')
            {
                console.writeline($"{msg4} {sayi1 * sayi2} ");
            }
            else if (islem == '/')
            {
                console.writeline($"{msg4} {sayi1 / sayi2} ");

            }


            console.writeline("hava nasıl?");
            string havadurumu = console.readline().toupper();
            if (havadurumu == "güzel" || havadurumu == "iyi")
            {

                console.writeline("kaç derece?");
                sbyte derece = sbyte.parse(console.readline());
                if (derece <= 15)
                {
                    console.writeline("hava soğuk evde otur");

                }
                else if (derece >= 40 && derece <= 15)
                {
                    console.writeline("hava iyi dışarı çık");
                   else if (derece >= 40)
                    {
                        console.writeline("hava çok sıcak evde kal");
                    }
                }

            }
            else if (havadurumu == "kötü" || havadurumu == "berbat")
            {
                console.writeline("içeride kal");
            }
            else
            { console.writeline("hatalı giriş yaptınız"); }

            //exception handling : 
            //debug: hata ayıklama 

            try
            {
                console.writeline("bir sayı gir");
                byte sayi = byte.parse(console.readline());
            }
            catch (formatexception)
            {
                console.writeline("sayı ile giriniz");
            }
            8
            catch (overflowexception)
            {
                console.writeline("0-255 arası bir değer giriniz");
            }
            catch (exception ex)
            {

                console.writeline("bir hata oluştu");
                console.writeline("");
            }
            static sürekli olarak ramda tutulur(program calistigi surece)

            byte sayi = byte.parse(console.readline());
            if (sayi == 1)
                console.writeline("bir");
            else if (sayi == 2)
                console.writeline("iki");
            else if (sayi == 3)
                console.writeline("üç");
            else
                console.writeline("yanlış değer");

            switch (sayi)

            {
                case 1:
                    console.writeline("bir");
                    break;
                case 2:
                    console.writeline("iki");
                    break;
                case 3:
                    console.writeline("üç");
                    break;
                default:
                    console.writeline("yanlış giriş");
                    break;


                    {

                    }
            }


            kontrol k+s try
            kontrol k+u kod
            kontrol k + c not






        }
    }
    }