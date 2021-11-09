
namespace Haromszogek
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnAdatokBetoltese = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lbHibak = new System.Windows.Forms.ListBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.lbDerkekszoguk = new System.Windows.Forms.ListBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.lbDerekszoguAdatok = new System.Windows.Forms.ListBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnAdatokBetoltese
      // 
      this.btnAdatokBetoltese.Location = new System.Drawing.Point(42, 13);
      this.btnAdatokBetoltese.Name = "btnAdatokBetoltese";
      this.btnAdatokBetoltese.Size = new System.Drawing.Size(180, 36);
      this.btnAdatokBetoltese.TabIndex = 0;
      this.btnAdatokBetoltese.Text = "Adatok betöltése";
      this.btnAdatokBetoltese.UseVisualStyleBackColor = true;
      this.btnAdatokBetoltese.Click += new System.EventHandler(this.btnAdatokBetoltese_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lbHibak);
      this.groupBox1.Location = new System.Drawing.Point(42, 92);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(527, 155);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Hibák a kiválasztott állományban:";
      // 
      // lbHibak
      // 
      this.lbHibak.FormattingEnabled = true;
      this.lbHibak.Location = new System.Drawing.Point(6, 19);
      this.lbHibak.Name = "lbHibak";
      this.lbHibak.Size = new System.Drawing.Size(515, 121);
      this.lbHibak.TabIndex = 2;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.lbDerkekszoguk);
      this.groupBox2.Location = new System.Drawing.Point(48, 254);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(193, 184);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Derekszögű háromszögek";
      // 
      // lbDerkekszoguk
      // 
      this.lbDerkekszoguk.FormattingEnabled = true;
      this.lbDerkekszoguk.Location = new System.Drawing.Point(7, 20);
      this.lbDerkekszoguk.Name = "lbDerkekszoguk";
      this.lbDerkekszoguk.Size = new System.Drawing.Size(167, 160);
      this.lbDerkekszoguk.TabIndex = 0;
      this.lbDerkekszoguk.SelectedIndexChanged += new System.EventHandler(this.lbDerkekszoguk_SelectedIndexChanged);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.lbDerekszoguAdatok);
      this.groupBox3.Location = new System.Drawing.Point(333, 274);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(362, 160);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Kiválasztott derékszögű háromszög adatai:";
      // 
      // lbDerekszoguAdatok
      // 
      this.lbDerekszoguAdatok.FormattingEnabled = true;
      this.lbDerekszoguAdatok.Location = new System.Drawing.Point(7, 20);
      this.lbDerekszoguAdatok.Name = "lbDerekszoguAdatok";
      this.lbDerekszoguAdatok.Size = new System.Drawing.Size(349, 134);
      this.lbDerekszoguAdatok.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnAdatokBetoltese);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnAdatokBetoltese;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListBox lbHibak;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ListBox lbDerkekszoguk;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.ListBox lbDerekszoguAdatok;
  }
}

