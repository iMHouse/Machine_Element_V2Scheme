using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Machine_Element_V2Scheme
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int variableRotationSpeed;
            float variablePowerWorking, variableTotalRatio, variableMechanicalEfficiencyTct, variableMechanicalEfficiencyAk, variableMechanicalEfficiencyPr;


            if (rotationSpeed.Text != "" && powerWorkingMachine.Text != "" && totalRatio.Text != "" && rotationSpeed.Text != "" && rotationSpeed.Text != "" && rotationSpeed.Text != "")
            {
                variableRotationSpeed = Int32.Parse(rotationSpeed.Text);
                variablePowerWorking = float.Parse(powerWorkingMachine.Text);
                variableTotalRatio = float.Parse(totalRatio.Text);
                variableMechanicalEfficiencyTct = float.Parse(mechanicalEfficiencyTct.Text);
                variableMechanicalEfficiencyAk = float.Parse(mechanicalEfficiencyAk.Text);
                variableMechanicalEfficiencyPr = float.Parse(mechanicalEfficiencyPr.Text);
                Buton.IsEnabled = false;
                outputTemp.Content = variableRotationSpeed;
            }
            else
                MessageBox.Show("You must enter a value!");
            
        }

        private void rotationSpeed_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsValid_integer(((TextBox)sender).Text + e.Text);
        }

        public static bool IsValid_integer(string str)
        {
            int i;
            return int.TryParse(str, out i);
        }

        private void powerWorkingMachine_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsValid_float(((TextBox)sender).Text + e.Text);
        }

        public static bool IsValid_float(string str)
        {
            float i;
            return float.TryParse(str, out i);
        }

        private void mechanicalEfficiency_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsValid_mechanicalEfficiency(((TextBox)sender).Text + e.Text);
        }

        public static bool IsValid_mechanicalEfficiency(string str)
        {
            float i;
            return float.TryParse(str, out i) && i <= 1;
        }


    }
}
