using static WinFormsApp1.DelegateClass;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelegateClass delegateClass = new DelegateClass();
            ValuesDelegate valueDeledate = new ValuesDelegate(delegateClass.Method1);
            valueDeledate += delegateClass.Method2;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}