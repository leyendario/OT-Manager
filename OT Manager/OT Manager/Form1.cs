using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace OT_Manager
{
   


    public partial class OTManager : Form
    {
        string Palabras_Reservadas = "";
        public Regex keyWords = new Regex("abstract|");
        public OTManager()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int selPos = ScriptEditor.SelectionStart;

            foreach (Match keyWordMatch in keyWords.Matches(ScriptEditor.Text))

            {
                ScriptEditor.Select(keyWordMatch.Index, keyWordMatch.Length);

                ScriptEditor.SelectionColor = Color.Blue;

                ScriptEditor.SelectionStart = selPos;

                ScriptEditor.SelectionColor = Color.Black;
            }

        }

    }
}

