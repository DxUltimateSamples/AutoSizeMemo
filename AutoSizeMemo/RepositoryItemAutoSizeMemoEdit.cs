namespace AutoSizeMemo
{
    using System.ComponentModel;
    using System.Windows.Forms;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Drawing;
    using DevExpress.XtraEditors.Registrator;
    using DevExpress.XtraEditors.Repository;
    using DevExpress.XtraEditors.ViewInfo;

    [UserRepositoryItem("RegisterAutoSizeMemoEdit")]
    public class RepositoryItemAutoSizeMemoEdit : RepositoryItemMemoEdit
    {
        private bool autoSizeInGridLayoutView;

        static RepositoryItemAutoSizeMemoEdit()
        {
            RegisterAutoSizeMemoEdit();
        }

        /// <summary>Initializes a new instance of the <see cref="RepositoryItemAutoSizeMemoEdit"/> class.Initializes a new <see cref="T:DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit" /> class instance with default settings.</summary>
        public RepositoryItemAutoSizeMemoEdit()
        {
            this.ScrollBars = ScrollBars.None;
        }

        public override string EditorTypeName
        {
            get
            {
                return nameof(AutoSizeMemoEdit);
            }
        }

        /// <summary>
        ///   <para>Gets or sets whether the control displays the horizontal and/or vertical scroll bar.</para>
        /// </summary>
        /// <value>A <see cref="T:System.Windows.Forms.ScrollBars" /> enumeration value that specifies whether the control displays the horizontal scroll bar, the vertical scroll bar, both, or has no scroll bars.</value>
        public override sealed ScrollBars ScrollBars
        {
            get
            {
                return base.ScrollBars;
            }

            set
            {
                base.ScrollBars = value;
            }
        }

        [Description("Gets or sets whether the editor's height is changed to display the editor's content in its entirety. This property is in effect when the editor resides within a LayoutView in side the DataGrid control.")]
        [DXCategory("Properties")]
        [RefreshProperties(RefreshProperties.All)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [DefaultValue(false)]
        public bool AutoSizeInGridLayoutView
        {
            get
            {
                return this.autoSizeInGridLayoutView;
            }

            set
            {
                if (this.autoSizeInGridLayoutView != value)
                {
                    this.autoSizeInGridLayoutView = value;
                    this.OnPropertiesChanged();
                }
            }
        }

        public static void RegisterAutoSizeMemoEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(nameof(AutoSizeMemoEdit), typeof(AutoSizeMemoEdit), typeof(RepositoryItemAutoSizeMemoEdit), typeof(MemoEditViewInfo), new MemoEditPainter(), true, null));
        }

        public override void Assign(RepositoryItem item)
        {
            this.BeginUpdate();
            try
            {
                base.Assign(item);
                if (item is RepositoryItemAutoSizeMemoEdit source)
                {
                    this.autoSizeInGridLayoutView = source.AutoSizeInGridLayoutView;
                }
            }
            finally
            {
                this.EndUpdate();
            }
        }
    }
}