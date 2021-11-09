
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
      this.groupBox1.SuspendLayout();
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
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnAdatokBetoltese);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnAdatokBetoltese;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListBox lbHibak;
  }
}

