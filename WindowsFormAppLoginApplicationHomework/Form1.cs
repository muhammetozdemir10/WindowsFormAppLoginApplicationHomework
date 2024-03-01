using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormAppLoginApplicationHomework
{
    public partial class Form1 : Form
    {
        /*
         * LOGIN UYGULAMASI
         * 
         * [TASARIM]
         * - Bir tane yazi alani ekelenecek.
         *  - yazi alanin adi (Name) usernameTextBox
         *  
         * - Bir tane yazi alani eklenecek.
         *  - yazi alanin adi (Name) passwordTextBox
         *  
         * - Bir tane button eklenecek.
         *  - Buttonun adi (Name) loginButton
         *  - Buttonun click olayi olusturulacak.
         * 
         * [KOD]
         * - Class scope'da sabit bir degisken tanimlanacak 
         *  - Degiskenin adi Username
         *  - Kullanici adini istedigin sekilde belirligebilirsin.
         *  
         * - Class scope'da sabit bir degisken tanimlanacak 
         *  - Degiskenin adi Password
         *  - Sifreyi istedigin sekilde belirligebilirsin.
         *  
         *  
         * - Login butonun click fonksiyonunda login algoritmasi yazilacak.
         * Login algoritmasinda kullanici adi ve sifre dogru oldugunda ekrana bir mesaj yazililacak.
         * (MessageBox)
         * 
         * NOT: TextBox'larin icinde yazilan yazilara erismek icin 
         * TextBox'in adini yazarak sonra .Text ozelligi ile icinde yazilan yaziyi ulasabilirsin.
         *
         * 
         */
        
         const string Username = "Wizee";
        const string Password = "Wizee6838";
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == Username && passwordTextBox.Text == Password)
            {
                MessageBox.Show("Giris Yapildi");
            }else
            {
                if (usernameTextBox.Text != Username)
                {
                    MessageBox.Show("Kullanici adinizi kontrol ediniz");
                    return;
                }
                

                if (passwordTextBox.Text != Password)
                {
                    MessageBox.Show("Sifrenizi kontrol ediniz");
                }
            }
        }
        
    }
}
