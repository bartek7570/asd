using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    /// 
    /// Struktura zawierająca treść pytania, i dwie możliwe odpowiedzi
    /// 
    struct Question
    {
        string tresc;
        string odp1;
        string odp2;

        public string odp11
        {

            set { odp1 = value; }
        }
        public string odp22
        {

            set { odp2 = value; }
        }
        public string trescc
        {

            set { tresc = value; }
        }
        public string Q
        {
            get
            {
                return tresc;
            }
        }
        public string A1
        {
            get
            {
                return odp1;
            }
        }
        public string A2
        {
            get
            {
                return odp2;
            }
        }

    }

    public partial class Form1 : Form
    {
        /// 
        /// Tablica zawierająca pytania
        /// 
        Question[] quest; 
        int pom=0;
        localhost.WebService1 Test = new localhost.WebService1();

        /// Konstruktor odpowowiadający także za uzupełnienie tablicy z pytaniami
        /// 
        /// 

        public Form1()
        {
            InitializeComponent();
            
            quest = new Question[10];

            quest[0].trescc = "8+9?";
            quest[0].odp11 = "17";
            quest[0].odp22 = "16";

            quest[1].trescc = "1*2";
            quest[1].odp11 = "2";
            quest[1].odp22 = "1";

            quest[2].trescc = "14-8?";
            quest[2].odp11 = "6";
            quest[2].odp22 = "8";

            quest[3].trescc = "2+1";
            quest[3].odp11 = "4";
            quest[3].odp22 = "3";

            quest[4].trescc = "5+2";
            quest[4].odp11 = "8";
            quest[4].odp22 = "7";

            
        }

        /// 
        /// służy do wykonywania zadań, takich jak przydzielanie zasobów używanych przez formularz
        /// 
        /// 
        /// 

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// 
        /// Przycisk służący do wyboru odpowiedzi pierwszej
        /// 
        /// 
        /// 
        private void button1_Click(object sender, EventArgs e)
        {
          textBox4.Text = Test.Questions(1, pom);

        }
        /// 
        /// Przycisk służący do wyboru odpowiedzi drugiej
        /// 
        /// 
        /// 
        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = Test.Questions(2, pom);
        }

        /// Przycisk służący do wyświetlenia pytania pierwszego

        private void button3_Click(object sender, EventArgs e)
        {
            pom = 0;
            textBox1.Text = quest[0].Q;
            textBox2.Text = quest[0].A1;
            textBox3.Text = quest[0].A2;
        }

        /// Przycisk służący do wyświetlenia pytania trzeciego

        private void button5_Click(object sender, EventArgs e)
        {
            pom = 2;
            textBox1.Text = quest[2].Q;
            textBox2.Text = quest[2].A1;
            textBox3.Text = quest[2].A2;
        }

        /// Przycisk służący do wyświetlenia pytania drugiego

        private void button4_Click(object sender, EventArgs e)
        {
            pom = 1;
            textBox1.Text = quest[1].Q;
            textBox2.Text = quest[1].A1;
            textBox3.Text = quest[1].A2;
        }

        /// Przycisk służący do wyświetlenia pytania czwartego

        private void button6_Click(object sender, EventArgs e)
        {
            pom = 3;
            textBox1.Text = quest[3].Q;
            textBox2.Text = quest[3].A1;
            textBox3.Text = quest[3].A2;
        }

        /// Przycisk służący do wyświetlenia pytania piątego

        private void button7_Click(object sender, EventArgs e)
        {
            pom = 4;
            textBox1.Text = quest[4].Q;
            textBox2.Text = quest[4].A1;
            textBox3.Text = quest[4].A2;
        }
    }
}
