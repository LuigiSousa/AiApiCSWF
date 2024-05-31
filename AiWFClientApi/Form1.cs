using AiWFClientApi.request;

namespace AiWFClientApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String prompt = txtPrompt.Text;
            txtResponse.Text = "";

            String response = postMethod.AiRequest(prompt);
            txtResponse.Text = response;
        }
    }
}
