﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModalModalessForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "종료합니다.";
            Application.ExitThread();  // 어플리케이션 쓰레드 완전 종료

        }

        private void ModalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowModal();

        }

        private void ShowModal()
        {
            this.statusMessage.Text = "모달 창을 띄웁니다.";
            FormModal m = new FormModal();
            m.Title = "모달 창띄우기";
            m.ShowDialog();
        }

    }
}
