using System;
using System.Linq;
using System.Windows.Forms;

namespace Dados
{
    public partial class Form1 : Form
    {
        private Random _rng = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonRoll_Click(object sender, EventArgs e)
        {
            // Obtener lados seleccionados
            int sides = int.Parse(comboBoxSides.SelectedItem.ToString());
            int count = (int)numericUpDownCount.Value;

            var results = new int[count];
            for (int i = 0; i < count; i++)
            {
                results[i] = _rng.Next(1, sides + 1);
            }

            // Mostrar resultados
            textBoxResults.Text = string.Join(", ", results);
        }
    }
}
