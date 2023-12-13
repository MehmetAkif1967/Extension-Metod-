using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp2._1
{
    using Uzunluk_Extension_Metod;
    using Upper_Lower_Extension_Metod;
    using targetchar_extension_metod;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin;
            metin = textBox1.Text;
            Console.WriteLine("Harf Sayısı= " + metin.uzunluk());
            Console.WriteLine("Cümle Sayısı= " + metin.uzunluk(true));
            Console.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string yazi;
            yazi = textBox1.Text;
            Console.WriteLine("Büyük harfe çevrilmiş hali= " +
                        yazi.ToUpper());
            Console.ReadLine();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string yazi;
            yazi = textBox1.Text;
            Console.WriteLine("Büyük harfe çevrilmiş hali= " +
                        yazi.ToLower());
            Console.ReadLine();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string yazi = textBox1.Text;
            Console.WriteLine("Aranacak harfi giriniz: ");
            char.TryParse(Console.ReadLine(), out char targetChar);

            int charCount = yazi.CountOccurrences(targetChar);
            Console.WriteLine($"{targetChar} harfi sayısı: {charCount}");
        }
    }
}
namespace Uzunluk_Extension_Metod
{
    static class Extension_Metod
    {
        
        public static int uzunluk(this string metin)
        {
            int harfsayisi = 0, noktasayisi, bosluksayisi;
            noktasayisi = metin.Split('.').Length - 1;
            bosluksayisi = metin.Split(' ').Length - 1;
            harfsayisi = metin.Length - (bosluksayisi + noktasayisi);
            return (harfsayisi);
        }

        
        public static int uzunluk(this string metin, bool cumlesay)
        {
            return (metin.Split('.').Length - 1);
        }
    }
}
namespace Upper_Lower_Extension_Metod
{
    static class Extension_Metod
    {
         
        public static string ToUpper(this string icerik)
        {
            return icerik.ToUpper();
        }
        public static string ToLower(this string icerik)
        {
            return icerik.ToLower();
        }
    }
}
namespace targetchar_extension_metod
{

    static class Extension_Metod
    {
        public static int CountOccurrences(this string metin, char karakter)
        {
            int sayma = 0;
            foreach (char c in metin)
            {
                if (char.ToUpper(c) == char.ToUpper(karakter))
                {
                    sayma++;
                }
            }
            return sayma;
        }
    }

}