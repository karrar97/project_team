﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_team
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               button1.Visible = false;
               button3.Visible = false;
               button4.Visible = false;
               button5.Visible = false;
               button6.Visible = false;
               

          }

          private void button5_Click(object sender, EventArgs e)
          {
               button1.Visible = false;
               button3.Visible = false;
               button4.Visible = false;
               button2.Visible = false;
               button6.Visible = false;
          }
     }
}
