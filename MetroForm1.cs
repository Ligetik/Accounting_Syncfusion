using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.XlsIO;
using System.IO;
using Syncfusion.WinForms.DataGridConverter.Events;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Windows.Forms.PdfViewer;
using Syncfusion.Pdf;
using Syncfusion.WinForms.DataGrid;

namespace SyncfusionWinFormsApp1
{
    public partial class MetroForm1 : SfForm
    {
        ContextMenuStrip recordContextMenu;
        public MetroForm1()
        {
            InitializeComponent();

            #region Form Styles
            this.Style.TitleBar.Height = (int)DpiAware.LogicalToDeviceUnits(38.0f);
            //this.Style.TitleBar.Height = 26;
            this.Style.TitleBar.BackColor = Color.White;
            this.Style.TitleBar.IconBackColor = Color.FromArgb(15, 161, 212);
            this.BackColor = Color.White;
            this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#343434");
            this.Style.TitleBar.CloseButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.HelpButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.IconHorizontalAlignment = HorizontalAlignment.Left;
            //this.Style.TitleBar.Font = this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Center;
            this.Style.TitleBar.TextVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            #endregion

            #region DataGrid1 Styles
            this.sfDataGrid1.GroupCaptionTextFormat = "{ColumnName}: {Key}             Кол-во записей: {ItemsCount}";
            this.sfDataGrid1.ShowBusyIndicator = true;
            #endregion



            #region RecordContextMenu

            recordContextMenu = new ContextMenuStrip();
            recordContextMenu.Items.Add("Подготовлено", Image.FromFile(@"../../Images/YellowSign.png"), OnPreparedClicked);
            recordContextMenu.Items.Add("Нужно сдать", Image.FromFile(@"../../Images/RedSign.png"), OnNeededClicked);
            recordContextMenu.Items.Add("Сдано", Image.FromFile(@"../../Images/GreenSign.png"), OnPassedClicked);
            this.sfDataGrid1.RecordContextMenu = recordContextMenu;
            #endregion
        }
        private void MetroForm1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sqlDataSet1.Декларация". При необходимости она может быть перемещена или удалена.
            this.декларацияTableAdapter.Fill(this.sqlDataSet1.Декларация);
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "sqlDataSet1.Статус". При необходимости она может быть перемещена или удалена.
                this.статусTableAdapter.Fill(this.sqlDataSet1.Статус);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "sqlDataSet.Квартал". При необходимости она может быть перемещена или удалена.
                this.кварталTableAdapter.Fill(this.sqlDataSet.Квартал);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "sqlDataSet.Организация". При необходимости она может быть перемещена или удалена.
                this.организацияTableAdapter.Fill(this.sqlDataSet.Организация);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "sqlDataSet1._3_НДФЛ". При необходимости она может быть перемещена или удалена.
                this._3_НДФЛTableAdapter.Fill(this.sqlDataSet1._3_НДФЛ);
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
           

            //this.sfDataGrid1.Columns.Add(new GridComboBoxColumn() { MappingName = "Квартал", HeaderText = "Квартал" });
            //(this.sfDataGrid1.Columns["Кварталы"] as GridComboBoxColumn).DataSource = sqlDataSet;

        }

        #region ContextMenu options
        private void OnPreparedClicked(object sender, EventArgs e)
        {

        }
        private void OnNeededClicked(object sender, EventArgs e)
        {

        }
        private void OnPassedClicked(object sender, EventArgs e)
        {

        }
        #endregion

        
        private void sfDataGrid1_QueryCellStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventArgs e)
        {
            if (e.ColumnIndex == 2 | e.ColumnIndex == 3 | e.ColumnIndex == 4 | e.ColumnIndex == 5 | e.ColumnIndex == 6 |
                e.ColumnIndex == 7 | e.ColumnIndex == 8 | e.ColumnIndex == 9 | e.ColumnIndex == 10 && e.DisplayText != null)
            {
                string Cell_color = Convert.ToString(e.DisplayText);

                switch (Cell_color)
                {
                    case "Подготовлено":
                        //Color.Yellow;
                        e.Style.BackColor = Color.FromArgb(238, 238, 0);
                        e.Style.TextColor = Color.FromArgb(238, 238, 0);
                        break;
                    case "Нужно сдать":
                        //Color.Red;
                        e.Style.BackColor = Color.FromArgb(246, 71, 71);
                        e.Style.TextColor = Color.FromArgb(246, 71, 71);
                        break;
                    case "Сдано":
                        //Color.Green;
                        e.Style.BackColor = Color.FromArgb(30, 130, 76);
                        e.Style.TextColor = Color.FromArgb(30, 130, 76);
                        break;
                    case "Синий":
                        //Color.DeepSkyBlue;
                        e.Style.BackColor = Color.FromArgb(107, 185, 240);
                        e.Style.TextColor = Color.FromArgb(107, 185, 240);
                        break;
                    case "Фиолетовый":
                        //Color.MediumPurple;
                        e.Style.BackColor = Color.FromArgb(155, 89, 182);
                        e.Style.TextColor = Color.FromArgb(155, 89, 182);
                        break;
                    default:
                        break;
                }
            }
        }

        #region ContextMenu Events
        private void sfDataGrid1_ContextMenuOpening(object sender, Syncfusion.WinForms.DataGrid.Events.ContextMenuOpeningEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 12 || e.ColumnIndex == 13 ||
                e.ColumnIndex == 14 || e.ColumnIndex == 15)
            {
                recordContextMenu.Items[0].Enabled = false;
                recordContextMenu.Items[1].Enabled = false;
                recordContextMenu.Items[2].Enabled = false;
            }
            else
            {
                recordContextMenu.Items[0].Enabled = true;
                recordContextMenu.Items[1].Enabled = true;
                recordContextMenu.Items[2].Enabled = true;
            }
        }
        #endregion

        //save//
        // try
        //    {
        //        организацияBindingSource.EndEdit();
        //        организацияTableAdapter.Update(this.sqlDataSet.Организация);

        //MessageBox.Show("Данные успешно сохранены!", "Сохранение", MessageBoxButtons.OK);
        //    }
        //    catch (Exception f)
        //    {
        //        MessageBox.Show(f.Message);
        //    }


        #region ExcelExport DataGrid1
        private void sfButtonExcel_Click(object sender, EventArgs e)
        {
            var options = new ExcelExportingOptions();
            options.ExcelVersion = ExcelVersion.Excel2013;
            options.CellExporting += OnCellExporting;
            var excelEngine = sfDataGrid1.ExportToExcel(sfDataGrid1.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];
            workBook.ActiveSheet.Columns[0].NumberFormat = "##";

            SaveFileDialog saveFilterDialog = new SaveFileDialog
            {
                FilterIndex = 2,
                Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx|Excel 2013 File(*.xlsx)|*.xlsx"
            };

            if (saveFilterDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (Stream stream = saveFilterDialog.OpenFile())
                {
                    if (saveFilterDialog.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel97to2003;
                    else if (saveFilterDialog.FilterIndex == 2)
                        workBook.Version = ExcelVersion.Excel2010;
                    else
                        workBook.Version = ExcelVersion.Excel2013;
                    workBook.SaveAs(stream);
                }

                //Message box confirmation to view the created workbook.
                if (MessageBox.Show(this.sfDataGrid1, "Do you want to view the workbook?", "Workbook has been created",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(saveFilterDialog.FileName);
                }
            }
        }

        private void OnCellExporting(object sender, DataGridCellExcelExportingEventArgs e)
        {
            if (e.ColumnName == "Налоги" || e.ColumnName == "СЗВ-М" || e.ColumnName == "ФСС" || e.ColumnName == "ЕНВД" ||
                e.ColumnName == "НДС" || e.ColumnName == "Прибыль" || e.ColumnName == "РСВ" || e.ColumnName == "НДФЛ" && e.CellValue != null)
            {

                string Cell_color = Convert.ToString(e.CellValue);
                if (e.CellType == ExportCellType.RecordCell)
                {
                    switch (Cell_color)
                    {
                        case "Подготовлено":
                            e.Range.CellStyle.Color = Color.Yellow;
                            e.Range.CellStyle.Font.Color = ExcelKnownColors.Yellow;
                            break;
                        case "Нужно сдать":
                            e.Range.CellStyle.Color = Color.Red;
                            e.Range.CellStyle.Font.Color = ExcelKnownColors.Red;
                            break;
                        case "Сдано":
                            e.Range.CellStyle.Color = Color.Green;
                            e.Range.CellStyle.Font.Color = ExcelKnownColors.Green;
                            break;
                        case "Синий":
                            e.Range.CellStyle.Color = Color.Blue;
                            e.Range.CellStyle.Font.Color = ExcelKnownColors.Blue;
                            break;
                        case "Фиолетовый":
                            e.Range.CellStyle.Color = Color.Magenta;
                            e.Range.CellStyle.Font.Color = ExcelKnownColors.Magenta;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        #endregion

        private void sfButton1_Click(object sender, EventArgs e)
        {
            //PdfDocumentView pdfDocumentView1 = new PdfDocumentView();

            ////Create Memory Stream to save pdfdocument.
            //MemoryStream pdfstream = new MemoryStream();

            //PdfDocument pdfDoc = new PdfDocument();
            //pdfDoc = sfDataGrid1.ExportToPdf();

            ////Save the PDF file
            //pdfDoc.Save(pdfstream);

            ////Load the pdfstream to pdfDocumentView
            //pdfDocumentView1.Load(pdfstream);

            //PrintDialog printdialog = new PrintDialog();
            //int pageCount = pdfDocumentView1.PageCount;
            //printdialog.AllowPrintToFile = true;
            //printdialog.AllowSomePages = true;
            //printdialog.PrinterSettings.FromPage = 1;
            //printdialog.PrinterSettings.ToPage = pageCount;
            //printdialog.PrinterSettings.MaximumPage = pageCount;
            //printdialog.PrinterSettings.MinimumPage = 1;

            //if (printdialog.ShowDialog() == DialogResult.OK)
            //{
            //    printdialog.Document = pdfDocumentView1.PrintDocument;
            //    printdialog.Document.Print();
            //}


            PrintPreviewDialog printdialog = new PrintPreviewDialog();

            MemoryStream pdfstream = new MemoryStream();

            //start 
            PdfExportingOptions options = new PdfExportingOptions();
            options.AutoColumnWidth = true;
            options.AutoRowHeight = true;
            options.RepeatHeaders = true;
            options.ExportGroupSummary = true;
            options.ExportFormat = true;
            options.FitAllColumnsInOnePage = false;
            options.ExportTableSummary = true;
            this.sfDataGrid1.AutoSizeController.ResetAutoSizeWidthForAllColumns();
            this.sfDataGrid1.AutoSizeController.Refresh();

            //Set document information. 
            Syncfusion.Pdf.PdfDocument document = new Syncfusion.Pdf.PdfDocument();
            document.PageSettings.Orientation = PdfPageOrientation.Landscape;

            // set pagewidth 
            double width = 0;
            foreach (var columns in sfDataGrid1.Columns)
                width += columns.ActualWidth;
            Graphics g = this.sfDataGrid1.CreateGraphics();
            width = (float)width * 60 / g.DpiX;
            g.Dispose();
            document.PageSettings.Width = (float)width;
            var page = document.Pages.Add();

            foreach (var columns in sfDataGrid1.Columns)
            {
                if (!columns.Visible)
                    options.ExcludeColumns.Add(columns.MappingName);
            }

            //Header and footer-start 
            RectangleF bounds = new RectangleF(0, 0, document.Pages[0].GetClientSize().Width, 50);
            RectangleF bounds1 = new RectangleF(0, 20, document.Pages[0].GetClientSize().Width, 50);
            PdfPageTemplateElement header = new PdfPageTemplateElement(bounds);
            document.Template.Top = header;
            Syncfusion.Pdf.Graphics.PdfFont font = new PdfStandardFont(PdfFontFamily.Courier, 16f, PdfFontStyle.Regular);
            header.Graphics.DrawString("NAME OF THE COMPANY", font, PdfPens.Black, bounds);
            Syncfusion.Pdf.Graphics.PdfFont font1 = new PdfStandardFont(PdfFontFamily.Courier, 12f, PdfFontStyle.Regular);
            header.Graphics.DrawString("Name of the Report", font1, PdfPens.Black, bounds1);
            //Header and footer-End 

            PdfViewerControl pdfviewer = new PdfViewerControl();
            var pdfGrid = sfDataGrid1.ExportToPdfGrid(sfDataGrid1.View, options);
            pdfGrid.Draw(page, new PointF());
            document.Save(@"../../1.pdf");
            pdfviewer.RenderingEngine = PdfRenderingEngine.SfPdf;
            pdfviewer.PrinterSettings.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.Fit;
            pdfviewer.PrinterSettings.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Landscape;
            pdfviewer.Load(@"../../1.pdf");
            printdialog.Document = pdfviewer.PrintDocument;
            printdialog.PrintPreviewControl.Document.PrinterSettings.DefaultPageSettings.Landscape = pdfviewer.PrinterSettings.PageOrientation == Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Landscape;
            printdialog.ShowDialog();

        }

        private void sfButtonSave_Click(object sender, EventArgs e)
        {

        }

        private void sfDataGrid1_CurrentCellEndEdit(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs e)
        {
            try
            {
                организацияBindingSource.EndEdit();
                организацияTableAdapter.Update(this.sqlDataSet.Организация);

                //MessageBox.Show("Данные успешно сохранены!", "Сохранение", MessageBoxButtons.OK);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Records_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            try
            {
                организацияBindingSource.EndEdit();
                организацияTableAdapter.Update(this.sqlDataSet.Организация);

                //MessageBox.Show("Данные успешно сохранены!", "Сохранение", MessageBoxButtons.OK);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void MetroForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                организацияBindingSource.EndEdit();
                организацияTableAdapter.Update(this.sqlDataSet.Организация);

                //MessageBox.Show("Данные успешно сохранены!", "Сохранение", MessageBoxButtons.OK);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}