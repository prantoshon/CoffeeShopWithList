using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeHouseWithList
{
    public partial class HomeUi : Form
    {
        List<string> customerNames = new List<string> { };
        List<string> customerNumbers = new List<string> { };
        List<string> customerAddresses = new List<string> { };
        List<string> orders = new List<string> { };
        List<int> quantitys= new List<int> { };
        List<int> bills = new List<int> { };
        

        int totalBillCalculator;
        int count = 0;


        public HomeUi()
        {
            InitializeComponent();
            
        }

        private void HomeUi_Load(object sender, EventArgs e)
        {

        }
        private void CustomerName() 
        {
            customerNames.Add(nameTextBox.Text);
        }

        private void ContractNumber() 
        {
           
            if (!customerNumbers.Contains(contractNumberTextBox.Text))
            {
              
                customerNumbers.Add(contractNumberTextBox.Text);
                
            }
            else 
            {
                MessageBox.Show("Contract number is already use");

                return;
            }
           
        }

        private void CustomerAddress() 
        {
            customerAddresses.Add(addressTextBox.Text);
        }

        private void Order() 
        {

            if (!String.IsNullOrEmpty(orderComboBox.Text))
            {
                orders.Add(orderComboBox.Text);
            }
            else 
            {
                MessageBox.Show("Order Is Empty");
                return;
            }
        }

        private void Quantity() 
        {
            if (quantityTextBox.Text !=null)
            {
               
                quantitys.Add(Convert.ToInt32(quantityTextBox.Text));
            }
            else
            {
                MessageBox.Show("Quantity is null");
                
            }
        }

        private void BillCalculate()
        {
            int totalQuantity;
            if (orderComboBox.Text == "Black-120") 
            {
               totalQuantity = Convert.ToInt32(quantityTextBox.Text);
               totalBillCalculator =  totalQuantity * 120;
             

            }
            else if (orderComboBox.Text == "Cold-100")
            {
                totalQuantity = Convert.ToInt32(quantityTextBox.Text);
                totalBillCalculator = totalQuantity * 100;
         
            }

            else if (orderComboBox.Text == "Hot-90")
            {
                totalQuantity = Convert.ToInt32(quantityTextBox.Text);
                totalBillCalculator = totalQuantity * 90;
              
            }
            else if (orderComboBox.Text == "Regular-80")
            {
                totalQuantity = Convert.ToInt32(quantityTextBox.Text);
                totalBillCalculator = totalQuantity * 80;
             
            }
            bills.Add(totalBillCalculator);
        }

     


        private void addButton_Click(object sender, EventArgs e)
        {
            showResultRichTextBox.Text = string.Empty;
            CustomerName();
            ContractNumber();
            CustomerAddress();
            Order();
            BillCalculate();
            

            showResultRichTextBox.AppendText("Name : " +nameTextBox.Text+" \n\n"+ "Number : " + contractNumberTextBox.Text +"\n\n"+ "Address : "+ addressTextBox.Text +"\n\n"+"Order : "+ orderComboBox.Text+" \n\n"+ "Quanityt : "+ quantityTextBox.Text +" \n\n"+"Total Bill :  "+ totalBillCalculator);
            nameTextBox.Text = string.Empty;
            contractNumberTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
            orderComboBox.Text = string.Empty;
            quantityTextBox.Text = string.Empty;

            count++;

            
        }

        private void ShowAllRecords()
        {
            showResultRichTextBox.Clear();
            for (int i = 0; i < customerNames.Count; i++)
            {

                showResultRichTextBox.Text += "Name : " + customerNames[i] + "\n" + "Contract Number : " + customerNumbers[i] + "\n" + "Customer Address : " + customerAddresses[i] + "\n" + "Total Bill : " + bills[i] + "\n\n";
            }

      

           
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowAllRecords();
        }
    }
}
