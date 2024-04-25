using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadEmployees();
        }

        public void LoadEmployees()
        {
            XmlDocument doc = new XmlDocument();
            string path = "C:\\Users\\stand\\source\\repos\\WinFormsApp38\\WinFormsApp38\\XMLFile1.xml";
            doc.Load(path);

            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                int age = int.Parse(node.SelectSingleNode("Age").InnerText);
                bool programmer = bool.Parse(node.SelectSingleNode("Programmer").InnerText);
                listBox1.Items.Add(new Employee(name, age, programmer));
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) 
            { 
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
            
            }
        }
    }
}



