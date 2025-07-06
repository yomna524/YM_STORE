using System;
using System.Windows.Forms;

namespace YM_STORE
{
    public partial class instruments : Form
    {
        private int pCounter1 = 0;
        private int pCounter2 = 0;
        private int pCounter3 = 0;
        private int pCounter4 = 0;
        private int pCounter5 = 0;
        private int pCounter6 = 0;

        private readonly int price1 = 9999;
        private readonly int price2 = 4900;
        private readonly int price3 = 9999;
        private readonly int price4 = 7999;
        private readonly int price5 = 25000;
        private readonly int price6 = 7500;

        public instruments()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            // Add event handlers for all buttons
            button1.Click += (s, e) => UpdateCount(ref pCounter1, label8, -1, price1);
            button8.Click += (s, e) => UpdateCount(ref pCounter1, label8, 1, price1);

            button3.Click += (s, e) => UpdateCount(ref pCounter2, label3, -1, price2);
            button9.Click += (s, e) => UpdateCount(ref pCounter2, label3, 1, price2);

            button7.Click += (s, e) => UpdateCount(ref pCounter3, label2, -1, price3);
            button10.Click += (s, e) => UpdateCount(ref pCounter3, label2, 1, price3);

            button4.Click += (s, e) => UpdateCount(ref pCounter4, label6, -1, price4);
            button13.Click += (s, e) => UpdateCount(ref pCounter4, label6, 1, price4);

            button6.Click += (s, e) => UpdateCount(ref pCounter5, label5, -1, price5);
            button12.Click += (s, e) => UpdateCount(ref pCounter5, label5, 1, price5);

            button5.Click += (s, e) => UpdateCount(ref pCounter6, label4, -1, price6);
            button11.Click += (s, e) => UpdateCount(ref pCounter6, label4, 1, price6);
        }

        private void UpdateCount(ref int count, Label label, int delta, int price)
        {
            count += delta;
            if (count < 0) count = 0; // Ensure count does not go negative

            // Debugging statement
            Console.WriteLine($"Updated count for label {label.Name}: {count}");

            label.Text = count.ToString();
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            int total = GetTotal();

            totalLabel.Text = total.ToString();
        }

        public int GetTotal()
        {
            return (pCounter1 * price1) +
                   (pCounter2 * price2) +
                   (pCounter3 * price3) +
                   (pCounter4 * price4) +
                   (pCounter5 * price5) +
                   (pCounter6 * price6);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            instruments2 instruments2Form = new instruments2(GetTotal());
            instruments2Form.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
