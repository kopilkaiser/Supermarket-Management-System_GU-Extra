using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEnd
{
    public partial class mdiBackEnd : Form
    {
        //create an object based on the security class
        clsDataConnection DB = new clsDataConnection();
        //create an instance of the main menu form
        //MainMenuForm Menu = new MainMenuForm();

        private int childFormNumber = 0;

        public mdiBackEnd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
