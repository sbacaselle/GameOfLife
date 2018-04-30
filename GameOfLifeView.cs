using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
  public partial class GameOfLifeView : Form
  {
    private readonly GameOfLifeModel _model;
    public GameOfLifeView()
    {
      InitializeComponent();
      SetupComboBox();
      _model = new GameOfLifeModel();
    }

    private void SetupComboBox()
    {
      var comboBoxSelection = new List<int> {1,10,50,100};
      comboBox1.DataSource = comboBoxSelection;
    }

    private async void goButton_Click(object sender, EventArgs e)
    {
      statusLabel.Visible = true;
      controlPanel.Enabled = false;
      drawablePictureBox.AllowDrawing = false;
      for (var count = 0; count < (int) comboBox1.SelectedValue; count++)
      {
        var nextGeneration = _model.RunGeneration(FastImageHelper.HelperMethods.ToBools(drawablePictureBox.Image));
        drawablePictureBox.RenewImage(FastImageHelper.HelperMethods.ToBitmap(nextGeneration));
        await Task.Delay(100);
      }

      statusLabel.Visible = false;
      controlPanel.Enabled = true;
      drawablePictureBox.AllowDrawing = true;
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      drawablePictureBox.RenewImage();
    }
  }
}
