using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Layout_Analyzer
{
    public partial class Form1 : Form
    {
        Module md = new Module(); 

        /*private void initVariable()
        {
            eleList = new List<String>(); 
        }*/

        public Form1()
        {
            //initVariable(); 
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text != "")
            {
                if (txtUrl.Text.Substring(0, 4) != "http" || txtUrl.Text.Substring(0, 3) == "www")
                {
                    txtUrl.Text = "http://" + txtUrl.Text;
                }
                webBrowser1.Url = new Uri(txtUrl.Text);
                //wb.Navigate(txtUrl.Text); 
            } 
            else 
            { 
                MessageBox.Show("Please insert the url."); 
            } 
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            md.GetAllElements(webBrowser1, listBoxElements);
            lblElements.Text = "Elements : " + "\r\nTotal : " + listBoxElements.Items.Count;
            //txtText.Text = webBrowser1.DocumentText.ToString();
            //txtText.Text = md.FormatInnerText(webBrowser1.DocumentText.ToString()); 
            txtText.Text = md.FormatHtml(webBrowser1.DocumentText.ToString());
        }  

        private void listBoxElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxIndex.Items.Clear(); 
            md.GetIndexList().Clear(); 
            md.GetTagCollection(webBrowser1, listBoxIndex, listBoxElements.SelectedItem.ToString());  
            lblIndex.Text = "Index : " + "\r\nTotal : " + listBoxIndex.Items.Count; 
        }

        private void listBoxIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAttribute.Items.Clear(); 
            md.GetAttList().Clear(); 
            md.GetAttributeCollection(webBrowser1, listBoxIndex, listBoxAttribute, listBoxElements.SelectedItem.ToString()); 
            lblAttribute.Text = "Attributes : " + "\r\nTotal : " + listBoxAttribute.Items.Count; 
        } 
    }
}
