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
    }

    private void btnAdatokBetoltese_Click(object sender, EventArgs e)
    {
      lbHibak.Items.Clear();
      lbDerkekszoguk.Items.Clear();
      szamlalo = 1;
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = "Text files (.txt) |*.txt";
      if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        StreamReader be = new StreamReader(ofd.FileName);
        while (!be.EndOfStream)
        {
          try
          {
            haromszogek.Add(new DHaromszog(be.ReadLine(),szamlalo));
          }
          catch (Exception ex)
          {
            
            lbHibak.Items.Add($"{szamlalo}.sor: "+ ex.Message); 
          }
          szamlalo++;
        }
        be.Close();
        szamlalo = 1;


        for (int i = 0; i < haromszogek.Count; i++)
        {
          if (Math.Pow(haromszogek[i].a, 2) + Math.Pow(haromszogek[i].b, 2) == Math.Pow(haromszogek[i].c, 2))
          {
            lbDerkekszoguk.Items.Add($"{haromszogek[i].Sorszama}. sor: a = {haromszogek[i].a} b = {haromszogek[i].b} c = {haromszogek[i].c}");
          } 
        }
          
        
      }

    }

    private void lbDerkekszoguk_SelectedIndexChanged(object sender, EventArgs e)
    {
      lbDerekszoguAdatok.Items.Clear();
      int index = Convert.ToInt32(lbDerkekszoguk.SelectedIndex.ToString().Substring(0,1));
      lbDerekszoguAdatok.Items.Add($"Kerület: {haromszogek[index].Kerulet}");
      lbDerekszoguAdatok.Items.Add($"Terület: {haromszogek[index].Terulet}");
    }
  }
}
