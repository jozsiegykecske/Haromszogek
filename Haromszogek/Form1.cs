using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Haromszogek
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    static List<DHaromszog> haromszogek = new List<DHaromszog>();
    private void Form1_Shown(object sender, EventArgs e)
    {
      try
      {
        DHaromszog valami = new DHaromszog("3 3 5", 1);
        Console.WriteLine("Eddig jó!");
      }
      catch (Exception ex)
      {

        
      }
     
      
      
      //Console.WriteLine(valami.Kerulet);
      //Console.WriteLine(valami.Terulet);

    }

    private void btnAdatokBetoltese_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        StreamReader be = new StreamReader(ofd.FileName);
        int szamlalo = 0;
        while (!be.EndOfStream)
        {
          try
          {
            haromszogek.Add(new DHaromszog(be.ReadLine(),1));
          }
          catch (Exception ex)
          {

            lbHibak.Items.Add($"{szamlalo}.sor: "+ ex.Message);
          }
          szamlalo++;
        }
        be.Close();
      }

    }
  }
}
