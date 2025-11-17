namespace Assignment__2._3
{
    public partial class CafeAntoinette : Form
    {
        int m_order = 5;
        //Start Customer Order with $0
        int m_totalDUE = 5;
        int m_TotalRev = 0;

        public CafeAntoinette()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CustomerOrder_Click(object sender, EventArgs e)
        {

        }

        private void CustomerName_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartOrder_Click(object sender, EventArgs e)
        {

            // We can display the total amount due for the customer
            //Each coffe are $5
            // Every time a coffee is purchases the label of total revenue should increase by the cost of the coffee
            m_totalDUE = m_totalDUE;
            // Let's display the Total revenue in the label
            labelCustomerTotal.Text = m_totalDUE.ToString();
            //
            //We are goin to Display the Customer Name and Order when ready


        }

        private void OrderReady_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: $"Customer Order {textCustomerName.Text}  {textCustomerOrder.Text}");





        }

        private void CompleteOrder_Click(object sender, EventArgs e)
        {
            //Add Total revenue after every customer order is finished  
            m_TotalRev = m_totalDUE + m_TotalRev;
            // Let's Display the Total Rev after Customer Order is Complete
            labelTotalRev.Text = m_TotalRev.ToString();
        }
    }
}



    