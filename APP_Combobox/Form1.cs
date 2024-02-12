namespace APP_Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CboAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxTAsingatura.Text = CboAsignatura.Text;
            TxTAsingatura.ForeColor = Color.Blue;
            TxTindice.Text = CboAsignatura.SelectedIndex.ToString();
            TxTindice.ForeColor = Color.Green;

        }
    }
}
