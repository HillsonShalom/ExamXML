using System.Xml.Linq;

namespace ExamXML
{
    public partial class Form1 : Form
    {
        private string selectedYear;
        private string selectedMonth;
        private string selectedDayM;
        private string selectedDayW;
        private Dictionary<string, string> years = new Dictionary<string, string>();
        private List<string> months = new List<string>();
        private Dictionary<string, string> daysM = new Dictionary<string, string>();
        private Dictionary<string, string> daysW = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            UpdateComboes();
            UpdateListView();
        }

        public void UpdateComboes()
        {
            XDocument doc = XDocument.Load("data.xml");
            XElement root = doc.Root;
            XElement elYear = root.Element("year")!;
            XElement elMonth = root.Element("month")!;
            XElement elDayM = root.Element("dayM")!;
            XElement elDayW = root.Element("dayW")!;

            List<XElement> a = elYear.Elements("item").ToList();
            List<XElement> av = elYear.Elements("value").ToList();
            List<string> aa = new List<string>();
            for (int i = 0; i < a.Count; i++)
            {
                aa.Add(a[i].Value);
                years.Add(a[i].Value, av[i].Value);
            }
            year.DataSource = aa;


            List<XElement> b = elMonth.Elements("item").ToList();
            List<string> bb = new List<string>();
            for (int i = 0; i < b.Count; i++)
            {
                bb.Add(b[i].Value);
            }
            month.DataSource = bb;


            List<XElement> c = elDayM.Elements("day").ToList();
            List<XElement> cv = elDayM.Elements("value").ToList();
            List<string> cc = new List<string>();
            for (int i = 0; i < c.Count; i++)
            {
                cc.Add(c[i].Value);
                daysM.Add(c[i].Value, cv[i].Value);
            }
            dayM.DataSource = cc;


            List<XElement> d = elDayW.Elements("day").ToList();
            List<XElement> dv = elDayW.Elements("value").ToList();
            List<string> dd = new List<string>();
            for (int i = 0; i < d.Count; i++)
            {
                dd.Add(d[i].Value);
                daysW.Add(d[i].Value, dv[i].Value);
            }
            dayW.DataSource = dd;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            selectedYear = years[year.SelectedItem.ToString()];
            selectedMonth = month.SelectedItem.ToString();
            selectedDayM = daysM[dayM.SelectedItem.ToString()];
            selectedDayW = daysW[dayW.SelectedItem.ToString()];
            if (string.IsNullOrEmpty(selectedYear) || string.IsNullOrEmpty(selectedMonth) || string.IsNullOrEmpty(selectedDayM) || string.IsNullOrEmpty(selectedDayW))
            {
                MessageBox.Show("בחר ערך מכל השדות!");
                return;
            }
            string result = $"{selectedDayW} {selectedDayM} לירח {selectedMonth} {selectedYear}";
            label1.Text = result;

            XDocument doc = XDocument.Load("C:\\xmlFiles\\Rabanut.xml");
            XElement root = doc.Root;
            root.Add(new XElement("Query",
                new XElement("Year", year.SelectedItem.ToString()),
                new XElement("Month", selectedMonth),
                new XElement("DayInMonth", dayM.SelectedItem.ToString()),
                new XElement("DayInWeek", dayW.SelectedItem.ToString()),
                new XElement("Nusach", result)));
            doc.Save("C:\\xmlFiles\\Rabanut.xml");

            listView1.Items.Add(result);
            sendButton.Enabled = false;
        }

        private void buttonEnableBack(object sender, EventArgs e)
        {
            sendButton.Enabled = true;
        }
    
        private void UpdateListView()
        {
            XDocument doc = XDocument.Load("C:\\xmlFiles\\Rabanut.xml");
            XElement root = doc.Root!;
            List<XElement> list = root.Elements("Query").ToList();
            foreach (XElement element in list)
            {
                XElement e = element.Element("Nusach");
                listView1.Items.Add(e.Value);
            }
        }
    }
}
