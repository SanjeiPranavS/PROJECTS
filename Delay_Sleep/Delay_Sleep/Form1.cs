namespace Delay_Sleep
{
    public partial class Form1 : Form
    {
        CancellationTokenSource _tokenSource = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
        }
        void PutThreadSleep()
        {
            Thread.Sleep(5000);
        }

        //async Task PutTaskDelay()
        //{
        //    await Task.Delay(5000);
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            PutThreadSleep();
            MessageBox.Show("I am back");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _tokenSource.Cancel();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await PutTaskDelay();
            MessageBox.Show("I am back");

        }


        async Task PutTaskDelay()
        {

            try
            {
                await Task.Delay(5000, _tokenSource.Token);
            }
            catch (Exception e)
            {
            } 
            
           
        }
    }
}