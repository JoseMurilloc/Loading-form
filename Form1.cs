﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignGuna2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

   
    private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
    {

    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      guna2ProgressBar1.Increment(1);

    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
      guna2ProgressBar1.Value = 0;
      timer1.Start();
    }
  }
}
