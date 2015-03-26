using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Security
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            /***Metni 1 karakter şeklinde inceleme ***/

            Dictionary<string, int> metin = new Dictionary<string, int>();     // harfler ve adeti tutulacak
            string kelime = richTextBox1.Text.ToLower(System.Globalization.CultureInfo.CreateSpecificCulture("tr-tr")); //metin textbox tan okunuyor
            for (int sayac = 0; sayac < kelime.Length; sayac++)
            {
                if (!metin.ContainsKey(kelime.Substring(sayac, 1)))     
                {
                    int adet = kelime.Length - kelime.Replace(kelime.Substring(sayac, 1), "").Length;   //metin substringler
                    metin.Add(kelime.Substring(sayac, 1), adet);                                        //yardımı hesaplanıyor

                   
                }
            }
            listBox1.Items.Clear();                 //1 karakterin frekansı gösterileceği yeri temizleniyor
            foreach (KeyValuePair<string, int> item in metin)
            {
                listBox1.Items.Add(item.Key + " : " + item.Value.ToString() + " adet var.");    //1 karakterin frekansı yazdırılıyor
            }
            
            /***Metni 2 karakter şeklinde inceleme ***/


            Dictionary<string, int> metin2 = new Dictionary<string, int>();     // harfler ve adeti tutulacak
           
            for (int sayac2 = 0; sayac2 < kelime.Length-1; sayac2++)
            {

                if (!metin2.ContainsKey(kelime.Substring(sayac2, 2)))
                {
                    int adet2 = kelime.Length - kelime.Replace(kelime.Substring(sayac2, 2), "").Length;     //metin substringler 
                    metin2.Add(kelime.Substring(sayac2, 2), adet2);                                         //yardımı ile hesaplanıyor

                    listBox2.Items.Add(kelime.Substring(sayac2, 2) + " : " + (adet2 / 2).ToString() + " adet var.");   //2 karakterin frekansı yazdırılıyor
                    
                }
            }

            /***Metni 3 karakter şeklinde inceleme ***/

            Dictionary<string, int> metin3 = new Dictionary<string, int>();
            
            for (int sayac3 = 0; sayac3 < kelime.Length - 2; sayac3++)
            {

                if (!metin3.ContainsKey(kelime.Substring(sayac3, 3)))
                {
                    int adet3 = kelime.Length - kelime.Replace(kelime.Substring(sayac3, 3), "").Length;     //metin substringler yardımı ile hesaplanıyor
                    if (!metin3.Any())          
                    {
                        metin3.Add(kelime.Substring(sayac3, 3), adet3);
                        
                    }

                    listBox3.Items.Add(kelime.Substring(sayac3, 3) + " : " + (adet3 / 3).ToString() + " adet var.");   //3 karakterin frekansı yazdırılıyor
                        
                    
                }
            }
         

           
            

            


        }
    }
}
