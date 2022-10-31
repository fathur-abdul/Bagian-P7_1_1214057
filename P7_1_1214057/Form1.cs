using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace P7_1_1214057
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(816, 312);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNIM.Text != "")
            {
                if (tbNama.Text != "")
                {
                    if (rbLK.Checked || rbP.Checked)
                    {
                        if (tbAlamat.Text != "")
                        {
                            if (cbProgram.Text != "")
                            {
                                if (tbTahun.Text != "")
                                {
                                    if (tbSemester.Text != "")
                                    {
                                        MessageBox.Show
                                        ("Lengkap !!!",
                                         "Informasi Data Submit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Size = new Size(816, 634);
                                    }
                                    else
                                    {
                                        MessageBox.Show
                                        ("Semester Belum Diisi !!!",
                                         "Informasi Data Submit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show
                                    ("Tahun Akademik Belum Diisi !!!",
                                     "Informasi Data Submit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show
                                ("Program Studi Belum Diisi !!!",
                                 "Informasi Data Submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show
                            ("Alamat Belum Diisi !!!",
                             "Informasi Data Submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show
                        ("Jenis Kelamin Belum Diisi !!!",
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show
                    ("Nama Belum Diisi !!!",
                    "Informasi Data Submit",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show
               ("NIM Belum Diisi !!!",
               "Informasi Data Submit",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbTahun_TextChanged(object sender, EventArgs e)
        {
            if (tbTahun.Text == "")
            {
                epWrong.SetError(tbTahun, "");
            }
            else
            {
                if (Regex.IsMatch(tbTahun.Text, @"^\d{4}/\d{4}$"))
                {           
                    epWrong.SetError(tbTahun, "");   
                }
                else
                {
                    epWrong.SetError(tbTahun, "Format tahun akademik salah!");
                }
            }
        }

        private void tbSemester_TextChanged(object sender, EventArgs e)
        {
            if (tbSemester.Text == "")
            {
                epWrong.SetError(tbSemester, "");
            }
            else
            {
                if ((tbSemester.Text).All(Char.IsNumber))
                {
                    epWrong.SetError(tbSemester, "");
                }
                else
                {
                    epWrong.SetError(tbSemester, "Inputan semester hanya boleh angka!");
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                checkBox1.Enabled = true; checkBox1.Checked = false;
                checkBox2.Enabled = true; checkBox2.Checked = false;
                checkBox3.Enabled = true; checkBox3.Checked = false;
                checkBox4.Enabled = true; checkBox4.Checked = false;
                checkBox5.Enabled = true; checkBox5.Checked = false;
                checkBox6.Enabled = true; checkBox6.Checked = false;
                checkBox7.Enabled = true; checkBox7.Checked = false;
                checkBox8.Enabled = true; checkBox8.Checked = false;
                checkBox9.Enabled = false; checkBox9.Checked = false;
                checkBox10.Enabled = true; checkBox10.Checked = false;
                checkBox11.Enabled = true; checkBox11.Checked = false;
                checkBox12.Enabled = false; checkBox12.Checked = false;
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                checkBox1.Enabled = false; checkBox1.Checked = false;
                checkBox2.Enabled = true; checkBox2.Checked = false;
                checkBox3.Enabled = true; checkBox3.Checked = false;
                checkBox4.Enabled = true; checkBox4.Checked = false;
                checkBox5.Enabled = true; checkBox5.Checked = false;
                checkBox6.Enabled = true; checkBox6.Checked = false;
                checkBox7.Enabled = true; checkBox7.Checked = false;
                checkBox8.Enabled = true; checkBox8.Checked = false;
                checkBox9.Enabled = false; checkBox9.Checked = false;
                checkBox10.Enabled = true; checkBox10.Checked = false;
                checkBox11.Enabled = true; checkBox11.Checked = false;
                checkBox12.Enabled = true; checkBox12.Checked = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                checkBox1.Enabled = false; checkBox1.Checked = false;
                checkBox2.Enabled = true; checkBox2.Checked = false;
                checkBox3.Enabled = true; checkBox3.Checked = false;
                checkBox4.Enabled = true; checkBox4.Checked = false;
                checkBox5.Enabled = true; checkBox5.Checked = false;
                checkBox6.Enabled = true; checkBox6.Checked = false;
                checkBox7.Enabled = true; checkBox7.Checked = false;
                checkBox8.Enabled = true; checkBox8.Checked = false;
                checkBox9.Enabled = true; checkBox9.Checked = false;
                checkBox10.Enabled = true; checkBox10.Checked = false;
                checkBox11.Enabled = true; checkBox11.Checked = false;
                checkBox12.Enabled = false; checkBox12.Checked = false;
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            String jeniskelamin = null;
            if (rbLK.Checked)
            {
                jeniskelamin = rbLK.Text;
            }
            else
            {
                jeniskelamin = rbP.Text;
            }

            String tahunajar = null;
            if (rb2006.Checked)
            {
                tahunajar = rb2006.Text;
            }
            else if (rb2010.Checked)
            {
                tahunajar = rb2010.Text;
            }
            else
            {
                tahunajar = rb2014.Text;
            }

            String matkul = null;
            if (cbMatematika.Checked)
            {
                matkul += cbMatematika.Text + ", ";
            }

            if (cbJarkom.Checked)
            {
                matkul += cbJarkom.Text + ", ";
            }

            if (cbPem1.Checked)
            {
                matkul += cbPem1.Text + ", ";
            }

            if (cbPem2.Checked)
            {
                matkul += cbPem2.Text + ", ";
            }

            if (cbPem3.Checked)
            {
                matkul += cbPem3.Text + ", ";
            }

            if (cbPem4.Checked)
            {
                matkul += cbPem4.Text + ", ";
            }

            if (cbPem5.Checked)
            {
                matkul += cbPem5.Text + ", ";
            }

            if (cbPem6.Checked)
            {
                matkul += cbPem6.Text + ", ";
            }

            if (cbPem7.Checked)
            {
                matkul += cbPem7.Text + ", ";
            }

            if (cbOS.Checked)
            {
                matkul += cbOS.Text + ", ";
            }

            if (cbMRP.Checked)
            {
                matkul += cbMRP.Text + ", ";
            }

            if (cbPLog.Checked)
            {
                matkul += cbPLog.Text + ", ";
            }


            MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nNIM: " + tbNIM.Text +
                    "\nJenis Kelamin: " + jeniskelamin +
                    "\nAlamat: " + tbAlamat.Text +
                    "\nProgram Studi: " + cbProdi.Text +
                    "\nTahun Akademik: " + tbTahun.Text +
                    "\nSemester: " + tbSemester.Text +
                    "\n" + "\n" +
                    "\nTahun Akademik: " + tahunajar +
                    "\nMata kuliah: " + matkul,

                    "Terima kasih telah menggunakan aplikasi kami",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            tbNIM.Clear();
            tbNama.Clear();
            tbAlamat.Clear();
            rbLK.Checked = false;
            rbP.Checked = false;
            cbProgram.ResetText();
            tbTahun.Clear();
            tbSemester.Clear();
            cbJarkom.Checked = false;
            cbOS.Checked = false;
            cbPem1.Checked = false;
            cbPem2.Checked = false;
            cbPem3.Checked = false;
            cbPem4.Checked = false;
            cbPem5.Checked = false;
            cbPem6.Checked = false;
            cbPem7.Checked = false;
            cbMRP.Checked = false;
            cbPLog.Checked = false;
            rb2006.Checked = false;
            rb2010.Checked = false;
            rb2014.Checked = false;

            this.Size = new Size(816, 232);

        }
    }
}
