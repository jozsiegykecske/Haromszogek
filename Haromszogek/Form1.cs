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
    static int szamlalo = 1;
    private void Form1_Shown(object sender, EventArgs e)
    {
      
     
      
      
      //Console.WriteLine(valami.Kerulet);
      //Console.WriteLine(valami.Terulet);

    }

    private void btnAdatokBetoltese_Click(object sender, EventArgs e)
    {
      szamlalo = 1;
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = "Text files |*.txt";
      if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        StreamReader be = new StreamReader(ofd.FileName);
       
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
        foreach (var h in haromszogek)
        {
          szamlalo = 1;
          if (Math.Pow(h.a, 2) + Math.Pow(h.b, 2) == Math.Pow(h.c, 2))
          {
            lbDerkekszoguk.Items.Add($"{szamlalo}. sor: a = {h.a} b = {h.b} c = {h.c}");
          }
        }
      }

    }
  }
}
