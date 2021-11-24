using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;
using Microsoft.Win32;

namespace Sader_Hotkey_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Startup registry key and value
        private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private static readonly string StartupValue = "Sader_Hotkey_Creator";
        private static bool starting = false;
        public static bool fully_exit = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            starting = true;
            items_dataGridView.RowHeadersVisible = false;
            foreach (V.CommandList Type in Enum.GetValues(typeof(V.CommandList)))
            {
                type_comboBox.Items.Add((Type).ToString());
            }
            type_comboBox.SelectedIndex = 0;
            if (V.readConfig())
            {
                Pup_data();
            }
            if (Startup_Exist())
            {
                startup_checkBox.Checked = true;
            }
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            Hide();
            mini_notifyIcon.Visible = true;
            mini_notifyIcon.ShowBalloonTip(100);
            starting = false;
        }

        private void items_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            if (V.data_refresh) return;
            int ndx = items_dataGridView.SelectedCells[0].RowIndex;
            hold_label.Text = items_dataGridView.Rows[ndx].Cells[0].Value.ToString();
            press_label.Text = items_dataGridView.Rows[ndx].Cells[1].Value.ToString();
            type_comboBox.SelectedItem = items_dataGridView.Rows[ndx].Cells[2].Value.ToString();
            command_textBox.Text = items_dataGridView.Rows[ndx].Cells[3].Value.ToString();
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog app = new OpenFileDialog();
            if (app.ShowDialog() == DialogResult.OK)
            {
                command_textBox.Text = app.FileName;
            }
        }

        private void hold_button_Click(object sender, EventArgs e)
        {
            hold_label.Text = "Click";
            V.k1_cap = true;
        }
        private void press_button_Click(object sender, EventArgs e)
        {
            press_label.Text = "Click";
            V.k2_cap = true;
        }
        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (V.k1_cap)
            {
                hold_label.Text = e.KeyCode.ToString();
                V.k1_cap = false;
            }

            if (V.k2_cap)
            {
                press_label.Text = e.KeyCode.ToString();
                V.k2_cap = false;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Key key1;
            if (Enum.TryParse(hold_label.Text, out key1))
                if (!Enum.IsDefined(typeof(Key), key1)) return;

            Keys key2;
            if (Enum.TryParse(press_label.Text, out key2))
                if (!Enum.IsDefined(typeof(Keys), key2)) return;

            V.CommandList type;
            if (Enum.TryParse(type_comboBox.SelectedItem.ToString(), out type))
                if (!Enum.IsDefined(typeof(V.CommandList), type)) return;

            V.Key_1.Add(key1);
            V.Key_2.Add(key2);
            V.Type.Add(type);
            V.Commands.Add(command_textBox.Text);

            if (Pup_data())
            {
                V.saveConfig();
            }
        }
        
        private bool Pup_data()
        {

            V.data_refresh = true;
            items_dataGridView.ClearSelection();
            items_dataGridView.Rows.Clear();
            items_dataGridView.Refresh();
            for (int i = 0; i < V.Key_1.Count; i++)
            {
                items_dataGridView.Rows.Add(V.Key_1[i].ToString(), V.Key_2[i].ToString(), V.Type[i].ToString(), V.Commands[i]);
            }
            V.data_refresh = false;
            return true;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            int ndx = items_dataGridView.SelectedCells[0].RowIndex;
            string k1 = items_dataGridView.Rows[ndx].Cells[0].Value.ToString();
            string k2 = items_dataGridView.Rows[ndx].Cells[1].Value.ToString();
            string Type = items_dataGridView.Rows[ndx].Cells[2].Value.ToString();
            string command = items_dataGridView.Rows[ndx].Cells[3].Value.ToString();

            Key key1;
            if (Enum.TryParse(k1, out key1))
                if (!Enum.IsDefined(typeof(Key), key1)) return;

            Keys key2;
            if (Enum.TryParse(k2, out key2))
                if (!Enum.IsDefined(typeof(Keys), key2)) return;

            V.CommandList type;
            if (Enum.TryParse(Type, out type))
                if (!Enum.IsDefined(typeof(V.CommandList), type)) return;

            int ndx2 = ItemsExist(key1, key2, type, command);
            if (ndx2 == -1) return;
            V.Key_1.RemoveAt(ndx2);
            V.Key_2.RemoveAt(ndx2);
            V.Type.RemoveAt(ndx2);
            V.Commands.RemoveAt(ndx2);

            if (Pup_data())
            {
                V.saveConfig();
            }
        }

        private int ItemsExist(Key key, Keys keys, V.CommandList type, string command)
        {
            for (int i = 0; i < V.Key_1.Count; i++)
            {
                if (V.Key_1[i] == key && V.Key_2[i] == keys && V.Type[i] == type && V.Commands[i] == command)
                {
                    return i;
                }
            }
            return -1;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (starting) return;
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                mini_notifyIcon.Visible = true;
                mini_notifyIcon.ShowBalloonTip(100);
            }
            if (this.WindowState == FormWindowState.Normal)
            {
                this.ShowInTaskbar = true;
            }

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            mini_notifyIcon.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!fully_exit)
            {
                mini_notifyIcon.Visible = true;
                this.Hide();
                mini_notifyIcon.ShowBalloonTip(100);
                e.Cancel = true;
            }
        }

        private static void SetStartup()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
            key.SetValue(StartupValue, Application.ExecutablePath.ToString());
        }

        private static void UnSetStartup()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
            key.DeleteValue(StartupValue);
        }

        private static bool Startup_Exist()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
            return key.GetValueNames().Contains(StartupValue);
        }

        private void startup_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (startup_checkBox.Checked)
            {
                SetStartup();
            }
            else
            {
                UnSetStartup();
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            fully_exit = true;
            Application.Exit();
        }
    }
}
