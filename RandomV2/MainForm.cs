using System;
using System.Text;
using System.Windows.Forms;

namespace RandomStringGeneratorNamespace {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            LoadSettings();
        }

        private void GenerateButton_Click(object sender, EventArgs e) {
            CopyButton.Enabled = true;
            int count = (int)LengthNumeric.Value;
            StringBuilder sb = new StringBuilder(count);
            switch (TypeCombo.SelectedIndex) {
                case 0: //Десятичный
                    for (int x = 0; x != count; x++)
                        sb.Append((char)(48 + random.Next(10)));
                    break;
                case 1: //Двоичный
                    for (int x = 0; x != count; x++)
                        sb.Append((char)(48 + random.Next(2)));
                    break;
                case 2: //Шестнадцатеричный(низ)
                    for (int x = 0; x != count; x++) {
                        int Hexl = random.Next(16);
                        if (Hexl < 10)
                            sb.Append((char)(48 + Hexl));
                        else
                            sb.Append((char)(Hexl + 87));
                    }
                    break;
                case 3: //Шестнадцатеричный(вер)
                    for (int x = 0; x != count; x++) {
                        int Hexu = random.Next(16);
                        if (Hexu < 10)
                            sb.Append((char)(48 + Hexu));
                        else
                            sb.Append((char)(Hexu + 55));
                    }
                    break;
                case 4: //Буквенный(низ)
                    for (int x = 0; x != count; x++)
                        sb.Append((char)(97 + random.Next(26)));
                    break;
                case 5: //Буквенный(вер)
                    for (int x = 0; x != count; x++)
                        sb.Append((char)(65 + random.Next(26)));
                    break;
                case 6: //Буквенный
                    for (int x = 0; x != count; x++) {
                        int t = random.Next(52);
                        if (t < 26)
                            sb.Append((char)(65 + t));
                        else
                            sb.Append((char)(71 + t));
                    }
                    break;
                case 7: //Цифровой, буквенный(низ)
                    for (int x = 0; x != count; x++) {
                        int ntl = random.Next(36);
                        if (ntl < 10)
                            sb.Append((char)(ntl + 48));
                        else
                            sb.Append((char)(ntl + 87));
                    }
                    break;
                case 8: //Цифровой, буквенный(вер)
                    for (int x = 0; x != count; x++) {
                        int ntu = random.Next(36);
                        if (ntu < 10)
                            sb.Append((char)(48 + ntu));
                        else
                            sb.Append((char)(ntu + 55));
                    }
                    break;
                case 9: //Цифровой, буквенный
                    for (int x = 0; x != count; x++) {
                        int nt = random.Next(62);
                        if (nt < 10)
                            sb.Append((char)(48 + nt));
                        else if (nt < 36)
                            sb.Append((char)(nt + 87));
                        else
                            sb.Append((char)(nt + 29));
                    }
                    break;
            }
            OutputValue.Text = sb.ToString();
        }

        private void CopyButton_Click(object sender, EventArgs e) {
            Clipboard.SetText(OutputValue.Text);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Type = TypeCombo.SelectedIndex;
            Properties.Settings.Default.Length = LengthNumeric.Value;
            Properties.Settings.Default.Save();
        }

        private void LoadSettings() {
            LengthNumeric.Value = Properties.Settings.Default.Length;
            if (Properties.Settings.Default.Type >= 0 &&
                Properties.Settings.Default.Type < TypeCombo.Items.Count)
                TypeCombo.SelectedIndex = Properties.Settings.Default.Type;
            else
                TypeCombo.SelectedIndex = 0;
            TypeCombo.Text = TypeCombo.Items[TypeCombo.SelectedIndex].ToString();
        }
    }
}
