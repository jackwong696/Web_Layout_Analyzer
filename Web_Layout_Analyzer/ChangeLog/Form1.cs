using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selenium_Program
{
    public partial class Form1 : Form
    {
        List<String> eleList;
        List<String> indexList;
        List<String> attList;
 
        private void initVariable()
        {
            eleList = new List<String>(); 
        }

        public Form1()
        {
            initVariable(); 
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text != "")
            {
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
            GetAllElements();
        }

        private void GetAllElements()
        {
            foreach (HtmlElement ele in webBrowser1.Document.All)
            {
                eleList.Add(ele.TagName.ToString());
            }
            if (eleList.Count != 0)
            {
                listBoxElements.Items.AddRange(eleList.Distinct().ToArray());
            }
        }

        private void GetTagCollection(String tagName)
        {
            for (int eleCount = 0; eleCount < webBrowser1.Document.GetElementsByTagName(tagName).Count; eleCount++)
            {
                indexList.Add(eleCount.ToString());
            }
            if (indexList.Count != 0)
            {
                listBoxIndex.Items.AddRange(indexList.ToArray());
            }
        }

        private void GetAttributeCollection(String tagName)
        {
            /*
             * for (int eleCount = 0; eleCount < webBrowser1.Document.GetElementsByTagName(tagName).Count; eleCount++)
            {
                indexList.Add(eleCount.ToString());
            }
            */
            int eleCount = 0;

            foreach (HtmlElement ele in webBrowser1.Document.GetElementsByTagName(tagName))
            {
                if(eleCount == (listBoxIndex.SelectedIndex + 1))
                {
                    //listBoxAttribute.Items.AddRange(webBrowser1.Document.GetElementsByTagName(tagName)[eleCount].Children.;
                }
            }
        }
    }
}
