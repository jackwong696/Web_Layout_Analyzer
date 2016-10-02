using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;

namespace Web_Layout_Analyzer
{
    class Module
    {
        List<String> eleList;
        List<String> indexList;
        List<String> attList;

        public Module()
        {
            eleList = new List<string>();
            indexList = new List<string>();
            attList = new List<string>(); 
        }

        public List<String> GetEleList()
        {
            return eleList; 
        } 

        public List<String> GetIndexList()
        {
            return indexList; 
        } 

        public List<String> GetAttList() 
        {
            return attList; 
        } 

        public void GetAllElements(WebBrowser webBrowser1, ListBox listBoxElements)
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

        public void GetTagCollection(WebBrowser webBrowser1, ListBox listBoxIndex, String tagName)
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

        public void GetAttributeCollection(WebBrowser webBrowser1, ListBox listBoxIndex, ListBox listBoxAttribute, String tagName)
        {
            //int eleCount = 0;

            foreach (HtmlElement ele in webBrowser1.Document.GetElementsByTagName(tagName)[listBoxIndex.SelectedIndex].All)
            {
                /*listBoxAttribute.Items.Add("ID : " + ele.Id);
                listBoxAttribute.Items.Add("Name : " + ele.Name);
                listBoxAttribute.Items.Add("Click : " + ele.Click()); */
                /*if (eleCount == (listBoxIndex.SelectedIndex + 1))
                {
                    listBoxAttribute.Items.Add(webBrowser1.Document.GetElementsByTagName(tagName)[eleCount].Parent.Children);
                }*/
            }
        }

        public String FormatInnerText(String innerText)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(innerText.ToString());
            //// Save the document to a file and auto-indent the output.
            //XmlTextWriter writer = new XmlTextWriter("data.xml", null); 
            //writer.Formatting = Formatting.Indented; 
            //doc.Save(writer); 
            //return writer.ToString(); 

            //return innerText.ToString().Replace("<", Environment.NewLine + "\t" + "<"); 
            //List<String> eleTag = new List<String>(); 
            //List<int> eleTagInt = new List<int>(); 

            //eleTag.Add(innerText.ToString().Contains("<*>")); 
            //eleTagInt.Add(innerText.ToString().IndexOf("<"));

            //foreach (int eleInt in eleTagInt)
            //{
            //    Console.WriteLine(eleInt + "\n");
            //}

            //foreach (String ele in innerText.ToString().Contains("<").ToString())
            //{

            //}

            //Regex.Match(innerText, "/<[^>] *>/ g"); 
            return innerText; 
        }

        public string FormatHtml(string innerText)
        {
            //white space before open angle bracket 
            //Regex r = new Regex(@"^[\w\s]"); 
            //string retVal = string.Empty; 
            //retVal = r.Replace(innerText, string.Format("$&{0}", string.Empty)); 

            //Opening tags 
            //Regex r = new Regex("<([a-z]+) *[^/]*?>");
            //Regex r = new Regex("^\\w\\s<[^>]*>");
            Regex r = new Regex("<[^>]*>");
            string retVal = string.Empty; 
            retVal = r.Replace(innerText, string.Format("$&{0}\t", Environment.NewLine));

            //Closing tags
            r = new Regex("</[^>]*>");
            retVal = r.Replace(retVal, string.Format("{0}\t$&{0}", Environment.NewLine));

            //Self closing tags
            r = new Regex("<[^>/]*/>");
            retVal = r.Replace(retVal, string.Format("$&{0}", Environment.NewLine));

            return retVal;
        }
    }
}
