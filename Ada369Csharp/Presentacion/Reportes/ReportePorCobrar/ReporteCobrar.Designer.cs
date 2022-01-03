namespace Ada369Csharp.Presentacion.REPORTES.ReportePorCobrar
{
    partial class ReporteCobrar
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.reportHeaderSection1 = new Telerik.Reporting.ReportHeaderSection();
            this.TextBox3 = new Telerik.Reporting.TextBox();
            this.TextBox2 = new Telerik.Reporting.TextBox();
            this.TextBox1 = new Telerik.Reporting.TextBox();
            this.TextBox8 = new Telerik.Reporting.TextBox();
            this.Table1 = new Telerik.Reporting.Table();
            this.TextBox5 = new Telerik.Reporting.TextBox();
            this.TextBox7 = new Telerik.Reporting.TextBox();
            this.TextBox4 = new Telerik.Reporting.TextBox();
            this.TextBox6 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2D);
            this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.TextBox3,
            this.TextBox2,
            this.TextBox1,
            this.TextBox8});
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0D);
            this.detail.Name = "detail";
            this.detail.Style.Visible = false;
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.132D);
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // reportHeaderSection1
            // 
            this.reportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(1.3D);
            this.reportHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.Table1});
            this.reportHeaderSection1.Name = "reportHeaderSection1";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.6D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.4D), Telerik.Reporting.Drawing.Unit.Cm(0.688D));
            this.TextBox3.Style.Font.Bold = false;
            this.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.TextBox3.Value = "= Now()";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0.688D));
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.TextBox2.Style.Font.Bold = true;
            this.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.TextBox2.Value = "REPORTE DE CUENTAS POR COBRAR";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(1.288D));
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.TextBox1.Style.Font.Bold = true;
            this.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.TextBox1.Value = "Total:";
            // 
            // TextBox8
            // 
            this.TextBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.7D), Telerik.Reporting.Drawing.Unit.Cm(1.288D));
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.289D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.TextBox8.Style.Font.Bold = false;
            this.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.TextBox8.Value = "=Sum(Fields.Saldo)";
            // 
            // Table1
            // 
            this.Table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(8.895D)));
            this.Table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.27D)));
            this.Table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(4.824D)));
            this.Table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.695D)));
            this.Table1.Body.SetCellContent(0, 0, this.TextBox5);
            this.Table1.Body.SetCellContent(0, 2, this.TextBox7);
            this.Table1.Body.SetCellContent(0, 1, this.textBox10);
            tableGroup1.Name = "tableGroup";
            tableGroup1.ReportItem = this.TextBox4;
            tableGroup2.Name = "group";
            tableGroup2.ReportItem = this.textBox9;
            tableGroup3.Name = "tableGroup1";
            tableGroup3.ReportItem = this.TextBox6;
            this.Table1.ColumnGroups.Add(tableGroup1);
            this.Table1.ColumnGroups.Add(tableGroup2);
            this.Table1.ColumnGroups.Add(tableGroup3);
            this.Table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.TextBox5,
            this.TextBox7,
            this.TextBox4,
            this.TextBox6,
            this.textBox9,
            this.textBox10});
            this.Table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.Table1.Name = "Table1";
            tableGroup4.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup4.Name = "detailTableGroup";
            this.Table1.RowGroups.Add(tableGroup4);
            this.Table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(16.989D), Telerik.Reporting.Drawing.Unit.Cm(1.3D));
            // 
            // TextBox5
            // 
            this.TextBox5.Format = "{0:d}";
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.895D), Telerik.Reporting.Drawing.Unit.Cm(0.695D));
            this.TextBox5.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.TextBox5.Value = "=Fields.Nombre";
            // 
            // TextBox7
            // 
            this.TextBox7.Format = "{0:N2}";
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.824D), Telerik.Reporting.Drawing.Unit.Cm(0.695D));
            this.TextBox7.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.TextBox7.Value = "=Fields.Saldo";
            // 
            // TextBox4
            // 
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.895D), Telerik.Reporting.Drawing.Unit.Cm(0.605D));
            this.TextBox4.Style.Font.Bold = true;
            this.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.TextBox4.Value = "Cliente";
            // 
            // TextBox6
            // 
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.824D), Telerik.Reporting.Drawing.Unit.Cm(0.605D));
            this.TextBox6.Style.Font.Bold = true;
            this.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.TextBox6.Value = "Saldo";
            // 
            // textBox9
            // 
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.27D), Telerik.Reporting.Drawing.Unit.Cm(0.605D));
            this.textBox9.Style.Font.Bold = true;
            this.textBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox9.StyleName = "";
            this.textBox9.Value = "Celular";
            // 
            // textBox10
            // 
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.27D), Telerik.Reporting.Drawing.Unit.Cm(0.695D));
            this.textBox10.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox10.StyleName = "";
            this.textBox10.Value = "=Fields.Celular";
            // 
            // ReporteCobrar
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detail,
            this.pageFooterSection1,
            this.reportHeaderSection1});
            this.Name = "ReporteCobrar";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Style.Font.Name = "Courier New";
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(17D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.ReportHeaderSection reportHeaderSection1;
        internal Telerik.Reporting.TextBox TextBox3;
        internal Telerik.Reporting.TextBox TextBox2;
        internal Telerik.Reporting.TextBox TextBox1;
        internal Telerik.Reporting.TextBox TextBox8;
        internal Telerik.Reporting.TextBox TextBox5;
        internal Telerik.Reporting.TextBox TextBox7;
        private Telerik.Reporting.TextBox textBox10;
        internal Telerik.Reporting.TextBox TextBox4;
        private Telerik.Reporting.TextBox textBox9;
        internal Telerik.Reporting.TextBox TextBox6;
        public Telerik.Reporting.Table Table1;
    }
}