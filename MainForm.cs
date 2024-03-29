﻿using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.XlsIO;
using System.IO;
using Syncfusion.WinForms.DataGridConverter.Events;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Windows.Forms.PdfViewer;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Grid;

namespace SyncfusionWinFormsApp1
{
    public partial class MetroForm1 : SfForm
    {
        //ContextMenuStrip recordContextMenu;
        //PdfGridCellStyle cellStyle;
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

            //cellStyle = new PdfGridCellStyle();


            //#region RecordContextMenu

            //recordContextMenu = new ContextMenuStrip();
            //recordContextMenu.Items.Add("Подготовлено", Image.FromFile(@"../../Images/YellowSign.png"), OnPreparedClicked);
            //recordContextMenu.Items.Add("Нужно сдать", Image.FromFile(@"../../Images/RedSign.png"), OnNeededClicked);
            //recordContextMenu.Items.Add("Сдано", Image.FromFile(@"../../Images/GreenSign.png"), OnPassedClicked);
            //this.sfDataGrid1.RecordContextMenu = recordContextMenu;
            //#endregion
        }
        private void MetroForm1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "sqlDataSet1.Статус". При необходимости она может быть перемещена или удалена.
                this.статусTableAdapter.Fill(this.sqlDataSet1.Статус);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "sqlDataSet.Квартал". При необходимости она может быть перемещена или удалена.
                this.кварталTableAdapter.Fill(this.sqlDataSet.Квартал);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "sqlDataSet.Организация". При необходимости она может быть перемещена или удалена.
                this.организацияTableAdapter.Fill(this.sqlDataSet.Организация);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "sqlDataSet1._3_НДФЛ1". При необходимости она может быть перемещена или удалена.
                this._3_НДФЛ1TableAdapter.Fill(this.sqlDataSet1._3_НДФЛ1);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "sqlDataSet1.Декларация1". При необходимости она может быть перемещена или удалена.
                this.декларация1TableAdapter.Fill(this.sqlDataSet1.Декларация1);

                //this.sfDataGrid1.ExpandAllGroup();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
           

            //this.sfDataGrid1.Columns.Add(new GridComboBoxColumn() { MappingName = "Квартал", HeaderText = "Квартал" });
            //(this.sfDataGrid1.Columns["Кварталы"] as GridComboBoxColumn).DataSource = sqlDataSet;

        }

        //#region ContextMenu options
        //private void OnPreparedClicked(object sender, EventArgs e)
        //{

        //}
        //private void OnNeededClicked(object sender, EventArgs e)
        //{

        //}
        //private void OnPassedClicked(object sender, EventArgs e)
        //{

        //}
        //#endregion

        
        private void sfDataGrid1_QueryCellStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22 when e.DisplayText != null:
                    {
                        string cellColor = Convert.ToString(e.DisplayText);

                        switch (cellColor)
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

                        break;
                    }
            }
        }

            //#region ContextMenu Events
            //private void sfDataGrid1_ContextMenuOpening(object sender, Syncfusion.WinForms.DataGrid.Events.ContextMenuOpeningEventArgs e)
            //{
            //    if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 12 || e.ColumnIndex == 13 ||
            //        e.ColumnIndex == 14 || e.ColumnIndex == 15)
            //    {
            //        recordContextMenu.Items[0].Enabled = false;
            //        recordContextMenu.Items[1].Enabled = false;
            //        recordContextMenu.Items[2].Enabled = false;
            //    }
            //    else
            //    {
            //        recordContextMenu.Items[0].Enabled = true;
            //        recordContextMenu.Items[1].Enabled = true;
            //        recordContextMenu.Items[2].Enabled = true;
            //    }
            //}
            //#endregion

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


        #region ExcelExport 
        private void sfButtonExcel1_Click(object sender, EventArgs e)
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
                if (MessageBox.Show(this.sfDataGrid1, "Вы действительно хотите посмотреть таблицу в Excel?", "Таблица Excel создана",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(saveFilterDialog.FileName);
                }
            }
        }
        private void sfButtonExcel2_Click(object sender, EventArgs e)
        {
            var options = new ExcelExportingOptions();
            options.ExcelVersion = ExcelVersion.Excel2013;
            options.CellExporting += OnCellExporting;
            var excelEngine = sfDataGrid2.ExportToExcel(sfDataGrid2.View, options);
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
                if (MessageBox.Show(this.sfDataGrid2, "Вы действительно хотите посмотреть таблицу в Excel?", "Таблица Excel создана",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(saveFilterDialog.FileName);
                }
            }
        }
        private void OnCellExporting(object sender, DataGridCellExcelExportingEventArgs e)
        {
            //            if (e.ColumnName == "Налоги" || e.ColumnName == "СЗВ-М I" || e.ColumnName == "СЗВ-М II" || e.ColumnName == "ФСС" || e.ColumnName == "ЕНВД" ||
            //e.ColumnName == "НДС" || e.ColumnName == "Прибыль" || e.ColumnName == "РСВ" || e.ColumnName == "НДФЛ" || e.ColumnName == "СЗВ-М III" ||
            //e.ColumnName == "2НДФЛ" || e.ColumnName == "УСН" || e.ColumnName == "Баланс" || e.ColumnName == "Статистика" || e.ColumnName == "СЗВ-СТАЖ" &&
            //e.CellValue != null)
            switch (e.ColumnName)
            {
                case "Налоги":
                case "СЗВ-М I":
                case "СЗВ-М II":
                case "ФСС":
                case "ЕНВД":
                case "НДС":
                case "Прибыль":
                case "РСВ":
                case "НДФЛ":
                case "СЗВ-М III":
                case "2НДФЛ":
                case "УСН":
                case "Баланс":
                case "Статистика":
                case "СЗВ-СТАЖ" when e.CellValue != null:
                    {

                        string cellColor = Convert.ToString(e.CellValue);
                        if (e.CellType == ExportCellType.RecordCell)
                        {
                            switch (cellColor)
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

                        break;
                    }
            }
        }

        #endregion

        #region Printing
        private void sfButtonPrinting1_Click(object sender, EventArgs e)
        {
            try
            {
                this.sfDataGrid1.ExpandAllGroup();
                //this.sfDataGrid1.ExpandGroupsAtLevel(2);
                sfDataGrid1.Columns["СЗВ-М III"].Visible = true;
                sfDataGrid1.Columns["2НДФЛ"].Visible = true;
                sfDataGrid1.Columns["УСН"].Visible = true;
                sfDataGrid1.Columns["Баланс"].Visible = true;
                sfDataGrid1.Columns["Статистика"].Visible = true;
                sfDataGrid1.Columns["СЗВ-СТАЖ"].Visible = true;

                PrintPreviewDialog printdialog = new PrintPreviewDialog();

                //MemoryStream pdfstream = new MemoryStream();
               
                //start 
                PdfExportingOptions options = new PdfExportingOptions();
                //cellStyle = new PdfGridCellStyle();
                //cellStyle.StringFormat = new PdfStringFormat() { Alignment = PdfTextAlignment.Right };


                options.AutoColumnWidth = true;
                options.AutoRowHeight = true;
                options.RepeatHeaders = true;
                options.ExportGroupSummary = true;
                options.ExportFormat = true;
                options.FitAllColumnsInOnePage = true;
                options.ExportTableSummary = true;
                options.CellExporting += options_CellExporting;
                this.sfDataGrid1.AutoSizeController.ResetAutoSizeWidthForAllColumns();
                this.sfDataGrid1.AutoSizeController.Refresh();

                //Set document information. 
                Syncfusion.Pdf.PdfDocument document = new Syncfusion.Pdf.PdfDocument();
                document.PageSettings.Size = PdfPageSize.A4;
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

                this.sfDataGrid1.CollapseAllGroup();
                sfDataGrid1.Columns["СЗВ-М III"].Visible = false;
                sfDataGrid1.Columns["2НДФЛ"].Visible = false;
                sfDataGrid1.Columns["УСН"].Visible = false;
                sfDataGrid1.Columns["Баланс"].Visible = false;
                sfDataGrid1.Columns["Статистика"].Visible = false;
                sfDataGrid1.Columns["СЗВ-СТАЖ"].Visible = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        void options_CellExporting(object sender, DataGridCellPdfExportingEventArgs e)
        {
            try
            {
                if (e.CellValue == null)
                {
                    e.CellValue = string.Empty;
                }

                var cellStyle = new PdfGridCellStyle();

                switch (e.ColumnName)
                {
                    case "Налоги":
                    case "СЗВ-М I":
                    case "СЗВ-М II":
                    case "ФСС":
                    case "ЕНВД":
                    case "НДС":
                    case "Прибыль":
                    case "РСВ":
                    case "НДФЛ":
                    case "СЗВ-М III":
                    case "2НДФЛ":
                    case "УСН":
                    case "Баланс":
                    case "Статистика":
                    case "СЗВ-СТАЖ" when e.CellValue != null:
                        {
                            if (e.CellType == ExportCellType.RecordCell)
                            {
                                string cellColor = Convert.ToString(e.CellValue);
                                switch (cellColor)
                                {
                                    case "Подготовлено":
                                        cellStyle.BackgroundBrush = PdfBrushes.Yellow;
                                        cellStyle.TextBrush = PdfBrushes.Black;
                                        e.PdfGridCell.Style = cellStyle;
                                        break;
                                    case "Нужно сдать":
                                        cellStyle.BackgroundBrush = PdfBrushes.Red;
                                        cellStyle.TextBrush = PdfBrushes.White;
                                        e.PdfGridCell.Style = cellStyle;
                                        break;
                                    case "Сдано":
                                        cellStyle.BackgroundBrush = PdfBrushes.Green;
                                        cellStyle.TextBrush = PdfBrushes.White;
                                        e.PdfGridCell.Style = cellStyle;
                                        break;
                                    case "Синий":
                                        cellStyle.BackgroundBrush = PdfBrushes.Blue;
                                        cellStyle.TextBrush = PdfBrushes.White;
                                        e.PdfGridCell.Style = cellStyle;
                                        break;
                                    case "Фиолетовый":
                                        cellStyle.BackgroundBrush = PdfBrushes.Purple;
                                        cellStyle.TextBrush = PdfBrushes.White;
                                        e.PdfGridCell.Style = cellStyle;
                                        break;
                                    default:
                                        break;
                                }
                                PdfFont font = new PdfTrueTypeFont(new Font("TimesRoman Unicode MS", 14), true);
                                e.PdfGridCell.Style.Font = font;
                            }

                            break;
                        }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void sfButtonPrinting2_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printdialog = new PrintPreviewDialog();

            //MemoryStream pdfstream = new MemoryStream();

            //start 
            PdfExportingOptions options = new PdfExportingOptions();
            //cellStyle = new PdfGridCellStyle();
            //cellStyle.StringFormat = new PdfStringFormat() { Alignment = PdfTextAlignment.Right };
            options.AutoColumnWidth = true;
            options.AutoRowHeight = true;
            options.RepeatHeaders = true;
            options.ExportGroupSummary = true;
            options.ExportFormat = true;
            options.FitAllColumnsInOnePage = true;
            options.ExportTableSummary = true;
            this.sfDataGrid2.AutoSizeController.ResetAutoSizeWidthForAllColumns();
            this.sfDataGrid2.AutoSizeController.Refresh();

            //Set document information. 
            Syncfusion.Pdf.PdfDocument document = new Syncfusion.Pdf.PdfDocument();
            document.PageSettings.Size = PdfPageSize.A4;
            document.PageSettings.Orientation = PdfPageOrientation.Landscape;

            // set pagewidth 
            double width = 0;
            foreach (var columns in sfDataGrid2.Columns)
                width += columns.ActualWidth;
            Graphics g = this.sfDataGrid2.CreateGraphics();
            width = (float)width * 60 / g.DpiX;
            g.Dispose();
            document.PageSettings.Width = (float)width;
            var page = document.Pages.Add();

            foreach (var columns in sfDataGrid2.Columns)
            {
                if (!columns.Visible)
                    options.ExcludeColumns.Add(columns.MappingName);
            }

            PdfViewerControl pdfviewer = new PdfViewerControl();
            var pdfGrid = sfDataGrid2.ExportToPdfGrid(sfDataGrid2.View, options);
            pdfGrid.Draw(page, new PointF());
            document.Save(@"../../2.pdf");
            pdfviewer.RenderingEngine = PdfRenderingEngine.SfPdf;
            pdfviewer.PrinterSettings.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.Fit;
            pdfviewer.PrinterSettings.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Landscape;
            pdfviewer.Load(@"../../2.pdf");
            printdialog.Document = pdfviewer.PrintDocument;
            printdialog.PrintPreviewControl.Document.PrinterSettings.DefaultPageSettings.Landscape = pdfviewer.PrinterSettings.PageOrientation == Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Landscape;
            printdialog.ShowDialog();

        }
        #endregion

        private void sfButtonSave_Click(object sender, EventArgs e)
        {

        }

        #region SaveChanges

        private void SaveChangesSfDataGrid1()
        {
            try
            {
                организацияBindingSource.EndEdit();
                организацияTableAdapter.Update(this.sqlDataSet.Организация);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void SaveChangesSfDataGrid2()
        {
            try
            {
                нДФЛ1BindingSource.EndEdit();
                _3_НДФЛ1TableAdapter.Update(this.sqlDataSet1._3_НДФЛ1);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void sfDataGrid1_CurrentCellEndEdit(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs e)
        {
            SaveChangesSfDataGrid1();
        }

        private void Records_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            SaveChangesSfDataGrid1();
            SaveChangesSfDataGrid2();
        }
        
        private void MetroForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChangesSfDataGrid1();
            SaveChangesSfDataGrid2();
        }
        #endregion
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void sfDataGrid2_CurrentCellEndEdit(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs e)
        {
            SaveChangesSfDataGrid2();

             
            //for (int i = 0; i > /*sfDataGrid2.RowCount*/sfDataGrid2.View.Records.Count - 1; i++)
            //foreach (var record in records)
            //{


            //    int rowIndex = i;
            //    int columnIndex = sfDataGrid2.TableControl.ResolveToGridVisibleColumnIndex(7);
            //if (columnIndex < 0)
            //    return;
            //var mappingName = sfDataGrid2.Columns[columnIndex].MappingName;
            //var recordIndex = sfDataGrid2.TableControl.ResolveToRecordIndex(rowIndex);
            //if (recordIndex < 0)
            //    return;
            //object data;
            //if (sfDataGrid2.View.TopLevelGroup != null)
            //    {
            //        var record = sfDataGrid2.View.TopLevelGroup.DisplayElements[recordIndex];
            //        if (!record.IsRecords)
            //            return;
            //        data = (record as Syncfusion.Data.RecordEntry).Data;
            //    }
            //    else
            //        data = sfDataGrid2.View.Records.GetItemAt(recordIndex);

                //    this.sfDataGrid2.View.GetPropertyAccessProvider().SetValue(data, mappingName, "Алина");
                //}
        }

        private void sfDataGrid1_GroupCollapsing(object sender, Syncfusion.WinForms.DataGrid.Events.GroupChangingEventArgs e)
        {
            if (e.Group.Key.Equals("4"))
            {
                sfDataGrid1.Columns["СЗВ-М III"].Visible = false;
                sfDataGrid1.Columns["2НДФЛ"].Visible = false;
                sfDataGrid1.Columns["УСН"].Visible = false;
                sfDataGrid1.Columns["Баланс"].Visible = false;
                sfDataGrid1.Columns["Статистика"].Visible = false;
                sfDataGrid1.Columns["СЗВ-СТАЖ"].Visible = false;
            }
        }

        void sfDataGrid1_GroupExpanding(object sender, Syncfusion.WinForms.DataGrid.Events.GroupChangingEventArgs e)
        {
            if (e.Group.Key.Equals("4"))
            {
                sfDataGrid1.Columns["СЗВ-М III"].Visible = true;
                sfDataGrid1.Columns["2НДФЛ"].Visible = true;
                sfDataGrid1.Columns["УСН"].Visible = true;
                sfDataGrid1.Columns["Баланс"].Visible = true;
                sfDataGrid1.Columns["Статистика"].Visible = true;
                sfDataGrid1.Columns["СЗВ-СТАЖ"].Visible = true;
            }
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            if (sfDataGrid1.CurrentCell != null)
            {
                sfDataGrid1.CurrentCell.ToString();
            }
        }
    }
}