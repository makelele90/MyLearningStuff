using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace WhatIsAthread
{
  public partial class Form1 : Form
  {
    private double sum = 0;
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      progressBar1.Style = ProgressBarStyle.Continuous;

      var thread = new Thread(SetName);
      thread.Start();
    }

    private void SetName()
    {
      Thread.Sleep(5000);

      Invoke(new Action<string>(SetLabelValue), "francis");
      
    }

    private void SetLabelValue(string name)
    {
      label1.Text = name;
    }
  }
}
