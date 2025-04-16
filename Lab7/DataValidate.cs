using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    partial class Form1
    {
        private void ValidateInputs()
        {
            bool valid = double.TryParse(inputA.Text, out double a) &&
                         double.TryParse(inputB.Text, out double b) &&
                         double.TryParse(inputDeltaX.Text, out double deltaX) &&
                         a < b && deltaX > 0;

            buttonOK.Enabled = valid &&
                              selectedFunctions != null &&
                              selectedFunctions.Length > 0 &&
                              !string.IsNullOrEmpty(selectedMethod);
        }

        private void inputA_ValueChanged(object sender, EventArgs e) => ValidateInputs();
        private void inputB_ValueChanged(object sender, EventArgs e) => ValidateInputs();
        private void inputDeltaX_ValueChanged(object sender, EventArgs e) => ValidateInputs();

        private void methodListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMethod = methodListBox.SelectedItem?.ToString();
            ValidateInputs();
        }

        private void funcListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newSelectedFunctions = new List<string>();
            foreach (var item in funcListBox.SelectedItems)
            {
                newSelectedFunctions.Add(item.ToString());
            }
            selectedFunctions = newSelectedFunctions.ToArray();
            ValidateInputs();

            graphicManager.UpdateFunctionGraphs(graphsPanel, selectedFunctions);
        }
    }
}
