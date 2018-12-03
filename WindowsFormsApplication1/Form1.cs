using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TriThuc trithuc = new TriThuc();
        List<string> kq = new List<string>();
        string[] facts;
        string[] info;
        string[] rulesarr;
        string[] errorsarr;

        private void Form1_Load(object sender, EventArgs e)
        {
            facts = System.IO.File.ReadAllLines(@"Facts.txt");
            info = System.IO.File.ReadAllLines(@"info.txt");
            rulesarr = System.IO.File.ReadAllLines(@"rules.txt");
            errorsarr = System.IO.File.ReadAllLines(@"errors.txt");
            foreach (string line in facts)
            {
                string temp = trithuc.TTSuKien(line);
                bhCheckedListBox.Items.Add(temp);
            }
        }

        private void chandoanbutton_Click(object sender, EventArgs e)
        {
            kqListBox.Items.Clear();
            knListBox.Items.Clear();
            kq.Clear();
            if (bhCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn biểu hiện nào!");
            }
            else
            {
                List<string> rules = new List<string>(rulesarr);
                List<string> errors = new List<string>(errorsarr);
                SuyDienTien suydientien = new SuyDienTien();


                List<string> check = new List<string>();


                for (int i = 0; i < bhCheckedListBox.CheckedItems.Count; i++)
                {
                    foreach (string line in facts)
                    {
                        if (trithuc.TTSuKien(line) == bhCheckedListBox.CheckedItems[i].ToString())
                        {
                            check.Add(trithuc.SuKien(line));
                        }
                    }
                }


                kq = suydientien.SuyDien(check, rules);
                

                    foreach (string item in kq)
                    {
                        foreach (string line in errors)
                        {
                            if (item == trithuc.SuKien(line))
                            {
                                kqListBox.Items.Add(trithuc.TTSuKien(line));
                            }
                        }
                    }

                if(kqListBox.Items.Count==0)
                {
                    List<string> skdaco =new List<string>(check);
                    List<string> hoi= new List<string>(check);
                    kq = suydientien.CacKQ(skdaco, rules);
                    hoi = suydientien.CacSuKienCan(skdaco, kq, rules);
                    foreach (string item in hoi)
                    {
                        if (!check.Contains(item))
                        {
                            string loi = trithuc.TimTTSuKien(item, facts);
                            DialogResult result = MessageBox.Show(string.Format("Bạn có thấy biểu hiên {0}?", loi), "Cần thêm thông tin",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                skdaco.Add(item);
                            }
                            else if (result == DialogResult.No)
                            {
                               
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                break;
                            }
                        }
                    }
                    foreach(string item in kq)
                    {
                        string temp = trithuc.TimTTSuKien(item,errorsarr);
                        List<string> kl= new List<string>(){item};
                        int phantram=suydientien.SuyDienPhanTram(skdaco,kl,rules);
                        kqListBox.Items.Add(temp);
                        if(phantram!=0)
                            knListBox.Items.Add(phantram);
                    }


                }
            }




        }

        private void suabutton_Click(object sender, EventArgs e)
        {
            suaTextBox.Clear();
            if (kqListBox.SelectedItem != null)
            {
                string selected = kqListBox.SelectedItem.ToString();
                string temp=trithuc.TimSuKien(selected,errorsarr);
                suaTextBox.Text = trithuc.TimTTSuKien(temp, info);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn lỗi nào trong khung kết quả!");
            }
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LienHeForm lienheform = new LienHeForm();
            lienheform.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtinform ttform = new thongtinform();
            ttform.ShowDialog();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDanForm hdform = new HuongDanForm();
            hdform.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





    }
}
