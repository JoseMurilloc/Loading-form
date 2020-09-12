namespace DesignGuna2
{
  partial class Form1
  {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
      this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
      this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
      this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
      this.guna2Panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // guna2Panel1
      // 
      this.guna2Panel1.BorderThickness = 1;
      this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
      this.guna2Panel1.Controls.Add(this.guna2Button1);
      this.guna2Panel1.Controls.Add(this.guna2ProgressBar1);
      this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(124)))), ((int)(((byte)(233)))));
      this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(1);
      this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
      this.guna2Panel1.Name = "guna2Panel1";
      this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
      this.guna2Panel1.Size = new System.Drawing.Size(800, 600);
      this.guna2Panel1.TabIndex = 0;
      // 
      // guna2ProgressBar1
      // 
      this.guna2ProgressBar1.BorderRadius = 4;
      this.guna2ProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
      this.guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
      this.guna2ProgressBar1.Location = new System.Drawing.Point(100, 277);
      this.guna2ProgressBar1.Name = "guna2ProgressBar1";
      this.guna2ProgressBar1.ShadowDecoration.BorderRadius = 4;
      this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
      this.guna2ProgressBar1.Size = new System.Drawing.Size(585, 10);
      this.guna2ProgressBar1.TabIndex = 0;
      this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
      this.guna2ProgressBar1.Value = 80;
      this.guna2ProgressBar1.ValueChanged += new System.EventHandler(this.guna2ProgressBar1_ValueChanged);
      // 
      // guna2Button1
      // 
      this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(77)))), ((int)(((byte)(230)))));
      this.guna2Button1.BorderRadius = 16;
      this.guna2Button1.BorderThickness = 1;
      this.guna2Button1.CheckedState.Parent = this.guna2Button1;
      this.guna2Button1.CustomImages.Parent = this.guna2Button1;
      this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
      this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.guna2Button1.ForeColor = System.Drawing.Color.White;
      this.guna2Button1.HoverState.Parent = this.guna2Button1;
      this.guna2Button1.Location = new System.Drawing.Point(339, 312);
      this.guna2Button1.Name = "guna2Button1";
      this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
      this.guna2Button1.Size = new System.Drawing.Size(120, 35);
      this.guna2Button1.TabIndex = 1;
      this.guna2Button1.Text = "Continue";
      this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // guna2DragControl1
      // 
      this.guna2DragControl1.TargetControl = this.guna2Panel1;
      // 
      // guna2ControlBox1
      // 
      this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(124)))), ((int)(((byte)(233)))));
      this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
      this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
      this.guna2ControlBox1.IconColor = System.Drawing.Color.Magenta;
      this.guna2ControlBox1.Location = new System.Drawing.Point(741, 12);
      this.guna2ControlBox1.Name = "guna2ControlBox1";
      this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
      this.guna2ControlBox1.Size = new System.Drawing.Size(35, 31);
      this.guna2ControlBox1.TabIndex = 1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
      this.ClientSize = new System.Drawing.Size(800, 600);
      this.Controls.Add(this.guna2Panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.guna2Panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private System.Windows.Forms.Timer timer1;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
  }
}

