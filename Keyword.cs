using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betterpad
{
    public partial class Keyword : Form
    {
        public Keyword()
        {
            InitializeComponent();
            InitializeLayout();
        }

        private void InitializeLayout()
        {
            TextBox2_TextChanged(null, null);

        }






        private void Button1_Click(object sender, EventArgs e)
        {
            string abc = textBox1.Text;
            EditorWindow.aaa.Add(abc);
            InitializeLayout();

        }


        private void Button2_Click(object sender, EventArgs e)
        {
            EditorWindow.aaa.Clear();
            InitializeLayout();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            string abc = String.Join(", ", EditorWindow.aaa.ToArray());
            textBox2.Text = abc;
        }
    }
}
