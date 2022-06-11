using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab12
{
    public partial class FormMain : Form
    {
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void continentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();

            continentBindingSource.EndEdit();
            continentTableAdapter.Update(countryDBDataSet.continent);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'countryDBDataSet.country' table. You can move, or remove it, as needed.
            countryTableAdapter.Fill(this.countryDBDataSet.country);
            // TODO: This line of code loads data into the 'countryDBDataSet.continent' table. You can move, or remove it, as needed.
            continentTableAdapter.Fill(countryDBDataSet.continent);
        }

        private void continentDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex != 1) return;

            Control edit = continentDataGridView.EditingControl;

            if (edit != null && e.FormattedValue.ToString() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(edit, "Название не может быть пустым!");
                errorProvider.SetIconAlignment(edit, ErrorIconAlignment.MiddleRight);
                errorProvider.SetIconPadding(edit, -20); // icon displays on left side of cell
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void countryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();

            countryBindingSource.EndEdit();
            countryTableAdapter.Update(countryDBDataSet.country);
            errorProvider.Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView drw = (DataRowView)countryBindingSource.Current;
            CountryDBDataSet.countryRow cr = (CountryDBDataSet.countryRow)(drw.Row);
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photoPictureBox.Image = Image.FromFile(ofd.FileName);
                toolStripStatusLabel.Text = "Фотография загружена успешно";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView drw = (DataRowView)countryBindingSource.Current;
            CountryDBDataSet.countryRow cr = (CountryDBDataSet.countryRow)(drw.Row);
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (photoPictureBox.Image != null)
                {
                    FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                    photoPictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fs.Close();
                    toolStripStatusLabel.Text = "Фотография успешно сохранена";
                }
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formProperties = new FormProperties(photoPictureBox);
            formProperties.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PrintDialog printDialog = new PrintDialog();
            //printDialog.Document = printDocument;
            //printDialog.UseEXDialog = true;

            //if (DialogResult.OK == printDialog.ShowDialog())
            //{
            //    printDocument.DocumentName = "Test Page Print";
            //    printDocument.Print();
            //}



            PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            objPPdialog.Document = printDocument;
            objPPdialog.ShowDialog();
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in countryDataGridView.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in countryDataGridView.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((GridCol.Width /
                            (double)iTotalWidth * iTotalWidth *
                            (e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                            GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                iRow = countryDataGridView.SelectedRows.Count > 0 ? countryDataGridView.SelectedRows[0].Index : countryDataGridView.Rows.Count; //

                if (iRow <= countryDataGridView.Rows.Count - 1) // while
                {
                    DataGridViewRow GridRow = countryDataGridView.Rows[iRow];
                    //iCellHeight = GridRow.Height + 5;
                    iCellHeight = photoPictureBox.Height;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        //break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            e.Graphics.DrawString("Отчёт",
                                new Font(countryDataGridView.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left,
                                e.MarginBounds.Top - e.Graphics.MeasureString("Отчёт",
                                new Font(countryDataGridView.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " +
                                DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate,
                                new Font(countryDataGridView.Font, FontStyle.Bold), Brushes.Black,
                                e.MarginBounds.Left +
                                (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                                new Font(countryDataGridView.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Width),
                                e.MarginBounds.Top - e.Graphics.MeasureString("Отчёт",
                                new Font(new Font(countryDataGridView.Font, FontStyle.Bold),
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            iTopMargin = e.MarginBounds.Top;

                            foreach (DataGridViewColumn GridCol in countryDataGridView.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);

                                iCount++;
                            }

                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }

                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                if (iCount < 2)
                                {
                                    e.Graphics.DrawString(Cel.Value.ToString(),
                                    Cel.InheritedStyle.Font,
                                    new SolidBrush(Cel.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount],
                                    iTopMargin,
                                    (int)arrColumnWidths[iCount], iCellHeight),
                                    strFormat);
                                }
                                else if (iCount == 2)
                                {
                                    e.Graphics.DrawString(id_continentComboBox.Text,
                                    Cel.InheritedStyle.Font,
                                    new SolidBrush(Cel.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount],
                                    iTopMargin,
                                    (int)arrColumnWidths[iCount], iCellHeight),
                                    strFormat);
                                }
                                else if (iCount == 3)
                                {
                                    e.Graphics.DrawImage(photoPictureBox.Image, new RectangleF((int)arrColumnLefts[iCount], iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));
                                }
                            }

                            e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }

                    iRow++;
                    iTopMargin += iCellHeight;
                }

                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void continentBindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        }
    }
}
