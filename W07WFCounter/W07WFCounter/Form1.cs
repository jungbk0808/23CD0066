namespace W07WFCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Count = 0;
        private void onAdd(object sender, EventArgs e)
        {
            label1.Text = $"{++Count}";
        }

        private void onSub(object sender, EventArgs e)
        {
            if (Count > 0)
            {
                label1.Text = (--Count).ToString();
            }
        }
    }
}