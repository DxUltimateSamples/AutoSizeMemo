namespace AutoSizeMemo
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    using DevExpress.XtraEditors;

    [DesignerCategory("")]
    [ToolboxItem(true)]
    public class AutoSizeMemoEdit : MemoEdit
    {
        private int previousHeight;

        static AutoSizeMemoEdit()
        {
            RepositoryItemAutoSizeMemoEdit.RegisterAutoSizeMemoEdit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSizeMemoEdit"/> class.
        ///   <para>Initializes a new <see cref="T:DevExpress.XtraEditors.MemoEdit" /> control instance with default settings.</para>
        /// </summary>
        public AutoSizeMemoEdit()
        {
            this.AutoSizeInLayoutControl = true;
        }

        /// <summary>
        ///     <para>Gets or sets whether the control's size is automatically calculated based on its content.</para>
        /// </summary>
        /// <value>true, if the control's size is automatically calculated; otherwise, false.</value>
        [Description("Gets or sets whether the control's size is automatically calculated based on its content.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [DefaultValue(false)]
        [DXCategory("Layout")]
        public override bool AutoSize
        {
            get
            {
                return base.AutoSize;
            }

            set
            {
                base.AutoSize = value;
                if (!value)
                {
                    return;
                }

                this.CheckAutoSize();
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether when a control is added to a
        ///     <see cref="T:DevExpress.XtraLayout.LayoutControl" />, this property specifies whether the control's width is
        ///     changed to display its content in its entirety.
        ///     This member is supported by individual descendant of the <see cref="T:DevExpress.XtraEditors.BaseControl" /> class.
        /// </summary>
        /// <value>true if auto-size mode is enabled; otherwise, false.</value>
        [Description("Gets or sets whether the editor's height is changed to display the editor's content in its entirety. This property is in effect when the editor resides within a LayoutControl.")]
        [DXCategory("Properties")]
        [RefreshProperties(RefreshProperties.All)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [DefaultValue(true)]
        public override sealed bool AutoSizeInLayoutControl
        {
            get
            {
                return base.AutoSizeInLayoutControl;
            }

            set
            {
                base.AutoSizeInLayoutControl = value;
            }
        }

        /// <summary>
        ///     <para>Gets or sets how the control is resized when automatic resizing is enabled.</para>
        /// </summary>
        /// <value>A value that specifies how the control is automatically resized.</value>
        [Description("Gets or sets how the control is resized when automatic resizing is enabled.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [DefaultValue(AutoSizeMode.GrowAndShrink)]
        [DXCategory("Layout")]
        public AutoSizeMode AutoSizeMode
        {
            get
            {
                return this.GetAutoSizeMode();
            }

            set
            {
                if (this.GetAutoSizeMode() == value)
                {
                    return;
                }

                this.SetAutoSizeMode(value);
                this.CheckAutoSize();
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return nameof(AutoSizeMemoEdit);
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemAutoSizeMemoEdit Properties
        {
            get
            {
                return base.Properties as RepositoryItemAutoSizeMemoEdit;
            }
        }

        protected override int CalcPreferredHeight()
        {
            var x = base.CalcPreferredHeight();
            return x;
        }

        protected override Size CalcSizeableMaxSize()
        {
            if (this.AutoSizeInLayoutControl)
            {
                var height = this.CalcAutoHeight() + this.Padding.Vertical;
                return new Size(0, height);
            }

            return base.CalcSizeableMaxSize();
        }

        protected override Size CalcSizeableMinSize()
        {
            if (this.AutoSizeInLayoutControl)
            {
                var height = this.CalcAutoHeight() + this.Padding.Vertical;
                ////var height = this.CalcAutoHeight();
                return new Size(0, height);
            }

            return base.CalcSizeableMinSize();
        }

        protected override void LayoutChanged()
        {
            base.LayoutChanged();
            this.CheckAutoSize();
        }

        protected override void OnEditValueChanged()
        {
            base.OnEditValueChanged();
            this.CheckAutoSize();
        }

        private void CheckAutoSize()
        {
            if (!this.AutoSize && !this.AutoSizeInLayoutControl)
            {
                return;
            }

            var newHeight = this.CalcAutoHeight();

            if (newHeight == this.previousHeight)
            {
                return;
            }

            this.previousHeight = newHeight;

            if (this.AutoSizeInLayoutControl)
            {
                this.RaiseSizeableChanged();
            }

            if (this.AutoSize)
            {
                if (newHeight != this.Size.Height && this.AutoSizeMode == AutoSizeMode.GrowAndShrink)
                {
                    this.Height = newHeight;
                }
                else if (newHeight > this.Size.Height)
                {
                    this.Height = newHeight;
                }
            }
        }
    }
}