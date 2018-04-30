namespace GameOfLife
{
  partial class GameOfLifeView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOfLifeView));
      this.drawablePictureBox = new DrawablePicturebox.DrawablePictureBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.controlPanel = new System.Windows.Forms.Panel();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.goButton = new System.Windows.Forms.Button();
      this.clearButton = new System.Windows.Forms.Button();
      this.statusLabel = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.controlPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // drawablePictureBox
      // 
      this.drawablePictureBox.AllowDrawing = true;
      this.drawablePictureBox.BrushColor = System.Drawing.Color.Black;
      this.drawablePictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
      this.drawablePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.drawablePictureBox.GridLines = true;
      this.drawablePictureBox.InverseBrushColor = System.Drawing.Color.White;
      this.drawablePictureBox.Location = new System.Drawing.Point(12, 12);
      this.drawablePictureBox.Margin = new System.Windows.Forms.Padding(0);
      this.drawablePictureBox.Name = "drawablePictureBox";
      this.drawablePictureBox.Size = new System.Drawing.Size(495, 308);
      this.drawablePictureBox.TabIndex = 0;
      this.drawablePictureBox.ZoomLevel = 8F;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.drawablePictureBox);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(4, 4);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(12);
      this.panel1.Size = new System.Drawing.Size(519, 332);
      this.panel1.TabIndex = 1;
      // 
      // controlPanel
      // 
      this.controlPanel.Controls.Add(this.statusLabel);
      this.controlPanel.Controls.Add(this.clearButton);
      this.controlPanel.Controls.Add(this.comboBox1);
      this.controlPanel.Controls.Add(this.goButton);
      this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.controlPanel.Location = new System.Drawing.Point(4, 336);
      this.controlPanel.Name = "controlPanel";
      this.controlPanel.Size = new System.Drawing.Size(519, 40);
      this.controlPanel.TabIndex = 2;
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(308, 8);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 1;
      // 
      // goButton
      // 
      this.goButton.Location = new System.Drawing.Point(435, 6);
      this.goButton.Name = "goButton";
      this.goButton.Size = new System.Drawing.Size(75, 23);
      this.goButton.TabIndex = 0;
      this.goButton.Text = "Go";
      this.goButton.UseVisualStyleBackColor = true;
      this.goButton.Click += new System.EventHandler(this.goButton_Click);
      // 
      // clearButton
      // 
      this.clearButton.Location = new System.Drawing.Point(12, 6);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(75, 23);
      this.clearButton.TabIndex = 2;
      this.clearButton.Text = "Clear";
      this.clearButton.UseVisualStyleBackColor = true;
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // statusLabel
      // 
      this.statusLabel.AutoSize = true;
      this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.statusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.statusLabel.Location = new System.Drawing.Point(149, 9);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(69, 20);
      this.statusLabel.TabIndex = 3;
      this.statusLabel.Text = "Running";
      this.statusLabel.Visible = false;
      // 
      // GameOfLifeView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(527, 380);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.controlPanel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "GameOfLifeView";
      this.Padding = new System.Windows.Forms.Padding(4);
      this.Text = "Game of Life";
      this.panel1.ResumeLayout(false);
      this.controlPanel.ResumeLayout(false);
      this.controlPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private DrawablePicturebox.DrawablePictureBox drawablePictureBox;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel controlPanel;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Button goButton;
    private System.Windows.Forms.Button clearButton;
    private System.Windows.Forms.Label statusLabel;
  }
}

