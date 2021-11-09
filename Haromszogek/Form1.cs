using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haromszogek
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      try
      {
        DHaromszog valami = new DHaromszog("3 3 5", 1);
        Console.WriteLine("Eddig jó!");
      }
      catch (Exception ex)
      {

        Console.WriteLine(ex.Message);
      }
     
      
      
      //Console.WriteLine(valami.Kerulet);
      //Console.WriteLine(valami.Terulet);

    }
  }
}
