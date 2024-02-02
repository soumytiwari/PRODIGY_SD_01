namespace Temperature_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] units = { "°F", "°C", "°K" };
            foreach (var unit in units)
            {
                cmbInputUnit.Items.Add(unit);
                cmbOutputUnit.Items.Add(unit);
            }

            cmbInputUnit.Text = units[0];
            cmbOutputUnit.Text = units[1];
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtTempInput.Text);
            double result = 0;
            string unit1 = cmbInputUnit.Text;
            string unit2 = cmbOutputUnit.Text;

            if (unit1 == unit2 )
            {
                result = value;
            }
            else if (unit1 == "°F")
            {
                if (unit2 == "°C")
                {
                    result = Converter.F_to_C(value);
                }
                else if (unit2 == "°K")
                {
                    result = Converter.F_to_K(value);
                }
            }
            else if (unit1 == "°C")
            {
                if (unit2 == "°F")
                {
                    result = Converter.C_to_F(value);
                }
                else if (unit2 == "°K")
                {
                    result = Converter.C_to_K(value);
                }
            }
            else if (unit1 == "°K")
            {
                if (unit2 == "°C")
                {
                    result = Converter.K_to_C(value);
                }
                else if (unit2 == "°F")
                {
                    result = Converter.K_to_F(value);
                }
            }

            result = Math.Round(result, 2);
            lblResult.Text = $"{result}{unit2}";
        }
    }
}