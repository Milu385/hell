using entregable1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hell
{
    public partial class Form3 : Form
    {

        Combatsystem combatsystem;
        Character character;

        public Form3(Combatsystem combatsystem, Character character)
        {
            InitializeComponent();
            this.combatsystem = combatsystem;
            this.character = character;
        }
    }
}
