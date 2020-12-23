using System.Threading;
using System.Windows.Forms;

namespace FNFDataManager
{
    public partial class Popup : Form
    {
        public static Button Button1 { get; set; }
        public static Button Button2 { get; set; }
        
        public bool result = false;
        
        public Popup(string title, string desc, string button1t, string button2t, bool showTextbox = false, string defaultText = "")
        {
            CheckForIllegalCrossThreadCalls = false;
                InitializeComponent();
                label1.Text = title;
                label2.Text = desc;
                button1.Text = button1t;
                button2.Text = button2t;
                Button1 = button1;
                Button2 = button2;
                if (showTextbox)
                {
                    textBox1.Visible = true;
                    textBox1.Text = defaultText;
                }

                button1.Click += (sender, args) => {
                    result = true;
                    Close();
                };
                button2.Click += (sender, args) => {
                    result = false;
                    Close();
                };
            }


    }
}