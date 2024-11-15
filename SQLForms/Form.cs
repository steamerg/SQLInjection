namespace SQLForms
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                //lbQueryResult.Text = CallHelper.CallQuery(tbQuery.Text).ToString();
                //MessageBox.Show(CallHelper.CallQuery(tbQuery.Text).ToString());
                //richTextBox1.Text = CallHelper.CallQuery(tbQuery.Text).ToString();

                List<User> users = CallHelper.CallQuery(tbQuery.Text);
                foreach (var item in users)
                {
                    richTextBox1.Text += item.ToString() +"\n";
                }
            }
            catch (NullReferenceException)
            {
                lbQueryResult.Text = "Exception thrown";
                
            }
            
        }
    }
}
