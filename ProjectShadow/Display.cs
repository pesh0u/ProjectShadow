using ProjectShadow.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProjectShadow
{
    public partial class Display : Form
    {
        private Dictionary<string, UserControl> loadedControls = new Dictionary<string, UserControl>();

        public Display()
        {
            InitializeComponent();
            ShowUserControl<LoginForm>();
        }

        public void ShowUserControl<T>() where T : UserControl, new()
        { 
            string key = typeof(T).Name;
            if (!loadedControls.ContainsKey(key)) loadedControls[key] = new T();
            UserControl control = loadedControls[key];
            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(control);
            control.BringToFront();
        }
    }
}
