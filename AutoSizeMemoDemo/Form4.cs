namespace LayoutControlTabBackColor
{
    using System.Drawing;

    public partial class Form4 : DevExpress.XtraEditors.XtraForm
    {
        public Form4()
        {
            InitializeComponent();

            departmentsTableAdapter1.Fill(departmentsDataSet1.Departments);
        }

        private void FormGrid_Load(object sender, System.EventArgs e)
        {
            this.propertyGridControl1.SelectedObject = this.gridControl1.MainView;
        }
    }
}
