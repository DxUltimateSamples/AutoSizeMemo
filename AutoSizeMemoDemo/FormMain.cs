namespace LayoutControlTabBackColor
{
    using System;

    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void AccordionControlElement2_Click(object sender, EventArgs e)
        {
            using (var form = new Form1())
            {
                form.ShowDialog(this);
            }
        }

        private void AccordionControlElement3_Click(object sender, EventArgs e)
        {
            using (var form = new Form2())
            {
                form.ShowDialog(this);
            }
        }

        private void AccordionControlElement4_Click(object sender, EventArgs e)
        {
            using (var form = new Form3())
            {
                form.ShowDialog(this);
            }
        }

        private void AccordionControlElement5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}