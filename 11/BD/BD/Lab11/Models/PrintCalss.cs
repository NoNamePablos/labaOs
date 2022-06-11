using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Lab11.Models { 
  public  class PrintExtendedListView
    {
        private ListView m_lvSource;
        private int m_nCurPrintRowIdx;
        private readonly IList<int> m_lstColumnsToPrint;
        private int m_nCurGroupIdx;
        private int v;

        public PrintExtendedListView(IList<int> lstColumnsToPrint)
        {
            m_lstColumnsToPrint = lstColumnsToPrint;
        }

       
        public void Print(ListView lvSource, bool landscape)
        {
            try
            {
                m_lvSource = lvSource;
                m_nCurPrintRowIdx = 0;

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += PatientsList_PrintPage;
                pd.DefaultPageSettings.Landscape = landscape;
                pd.DefaultPageSettings.Margins.Top = 10;
                pd.DefaultPageSettings.Margins.Left = 50;
                pd.DefaultPageSettings.Margins.Right = 50;
                pd.DefaultPageSettings.Margins.Bottom = 50;
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка печати Print", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                /* if (Globals.ErrorLog != null)
                     Globals.ErrorLog.LogError(ex);*/
            }
        }
        #region Private Methods
        private void PatientsList_PrintPage(object sender, PrintPageEventArgs e)
        {
            int nMaxLength = 0;
            int nColumnMaxLength = 0;
            ////////////////Определение столбца длинны////////////
            for (int i = 0; i < m_lstColumnsToPrint.Count; i++)
            {
                int index = m_lstColumnsToPrint[i];
                for (int j = 0; j < m_lvSource.Items.Count; j++)
                {
                    if (m_lvSource.Items[j].SubItems[index].Text.Length > nMaxLength)
                    {
                        nMaxLength = m_lvSource.Items[j].SubItems[index].Text.Length;
                        nColumnMaxLength = index;
                    }
                }
            }
            /////////////////////////////////////////////////////

            float[] maxLengths = new float[m_lvSource.Columns.Count];   //Массив, длинна которого соответствует количеству столбцов           
            foreach (int i in m_lstColumnsToPrint)
            {
                if (m_lvSource.Columns[i].Text.Length > maxLengths[i])
                    maxLengths[i] = m_lvSource.Columns[i].Width; //Записываем ширину каждого столбца (а если быть точным, то ширину только тех столбцов,
            }                                                    //которые пользователь выбрал для печати, в остальных случаях будет 0)

            List<float> arrSize = new List<float>();
            for (int i = 0; i < maxLengths.Length; i++)
            {
                arrSize.Add(maxLengths[i]);//Добавляем в лист ширину определённого столбца
            }


            try
            {
                float fTotalWidth = 0;
                float fCurY = e.MarginBounds.Top;

                foreach (int i in m_lstColumnsToPrint)
                    fTotalWidth += arrSize[i];

                if (fTotalWidth < e.MarginBounds.Width)
                    arrSize[nColumnMaxLength] += (e.MarginBounds.Width - fTotalWidth); //Если ширина таблицы выходит меньши ширины листа, то растягиваем самый широкий столбец

                PrintHeader(e, arrSize, ref fCurY);
                if (m_lvSource.Groups.Count > 0) //Проверяем есть ли в листе группы
                {
                    while (fCurY < e.MarginBounds.Bottom && m_nCurGroupIdx < m_lvSource.Groups.Count)
                    {
                        PrintGroupRow(e, m_lvSource.Groups[m_nCurGroupIdx], ref fCurY);
                        for (int i = m_nCurPrintRowIdx; i < m_lvSource.Groups[m_nCurGroupIdx].Items.Count; i++)
                        {
                            ListViewItem li = m_lvSource.Groups[m_nCurGroupIdx].Items[i];
                            PrintRow(e, arrSize, li, ref fCurY);
                            m_nCurPrintRowIdx = i + 1;
                            if (fCurY >= e.MarginBounds.Bottom)
                                break;
                        }
                        if (fCurY < e.MarginBounds.Bottom)
                        {
                            m_nCurGroupIdx++;
                            m_nCurPrintRowIdx = 0;
                        }
                    }
                    e.HasMorePages = (m_nCurGroupIdx < m_lvSource.Groups.Count || m_nCurPrintRowIdx != 0);
                }
                else
                {
                    while (fCurY < e.MarginBounds.Bottom && m_nCurPrintRowIdx < m_lvSource.Items.Count)
                    {
                        ListViewItem li = m_lvSource.Items[m_nCurPrintRowIdx];
                        PrintRow(e, arrSize, li, ref fCurY);
                        m_nCurPrintRowIdx++;
                    }
                    e.HasMorePages = (m_nCurPrintRowIdx < m_lvSource.Items.Count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка печати PatientsList_PrintPage", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                /* if (Globals.ErrorLog != null)
                     Globals.ErrorLog.LogError(ex);*/
                e.Cancel = true;
            }
        }

        private void PrintHeader(PrintPageEventArgs e, List<float> arrSizes, ref float fCurY)
        {
            Font fnt = new Font(m_lvSource.Font.FontFamily, 10f);
            RectangleF rcString = new RectangleF(e.MarginBounds.X, fCurY, arrSizes[m_lstColumnsToPrint[0]], 1f);
            foreach (int i in m_lstColumnsToPrint)
            {
                SizeF size = e.Graphics.MeasureString(m_lvSource.Columns[i].Text, fnt, (int)arrSizes[i]);
                if (rcString.Height < size.Height)
                    rcString.Height = size.Height;
            }
            fCurY += rcString.Height;
            if (fCurY > e.MarginBounds.Bottom)
            {
                m_nCurPrintRowIdx--;
                return;
            }
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            for (int i = 0; i < m_lstColumnsToPrint.Count; i++)
            {
                if (i > 0)
                    rcString.Offset(arrSizes[m_lstColumnsToPrint[i - 1]], 0);
                rcString.Width = arrSizes[m_lstColumnsToPrint[i]];
                e.Graphics.FillRectangle(Brushes.White, rcString.Left, rcString.Top, rcString.Width, rcString.Height);
                e.Graphics.DrawRectangle(Pens.Black, rcString.Left, rcString.Top, rcString.Width, rcString.Height);
                e.Graphics.DrawString(m_lvSource.Columns[m_lstColumnsToPrint[i]].Text, fnt, Brushes.Black, rcString, sf);
            }
        }

        private void PrintRow(PrintPageEventArgs e, List<float> arrSizes, ListViewItem row, ref float fCurY)
        {
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            sf.LineAlignment = StringAlignment.Center;
            RectangleF rcString = new RectangleF(e.MarginBounds.X, fCurY, arrSizes[m_lstColumnsToPrint[0]], 1f);
            Font fnt = new Font(row.Font.FontFamily, 10f);
            foreach (int i in m_lstColumnsToPrint)
            {
                SizeF size = e.Graphics.MeasureString(row.SubItems[i].Text, fnt, (int)arrSizes[i]);
                if (rcString.Height < size.Height)
                    rcString.Height = size.Height;
            }
            fCurY += rcString.Height;
            if (fCurY > e.MarginBounds.Bottom)
            {
                m_nCurPrintRowIdx--;
                return;
            }
            for (int i = 0; i < m_lstColumnsToPrint.Count; i++)
            {
                sf.Alignment = StringAlignment.Near;
                if (i > 0)
                {
                    rcString.Offset(arrSizes[m_lstColumnsToPrint[i - 1]], 0);
                    sf.Alignment = StringAlignment.Center;
                }
                rcString.Width = arrSizes[m_lstColumnsToPrint[i]];
                e.Graphics.DrawRectangle(Pens.Black, rcString.Left, rcString.Top, rcString.Width, rcString.Height);
                e.Graphics.DrawString(row.SubItems[m_lstColumnsToPrint[i]].Text, fnt, Brushes.Black, rcString, sf);
            }
        }


        private void PrintGroupRow(PrintPageEventArgs e, ListViewGroup group, ref float fCurY)
        {
            float[] arrSizes = { e.MarginBounds.Width * 1f };
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            RectangleF rcString = new RectangleF(e.MarginBounds.X, fCurY, arrSizes[0], 1f);
            Font fnt = group.ListView.Font;
            for (int i = 0; i < arrSizes.Length; i++)
            {
                string str = group.Header;
                SizeF size = e.Graphics.MeasureString(str, fnt, (int)arrSizes[i]);
                if (rcString.Height < size.Height)
                    rcString.Height = size.Height;
            }
            fCurY += rcString.Height;
            if (fCurY > e.PageBounds.Bottom)
                return;

            for (int i = 0; i < arrSizes.Length; i++)
            {
                string str = group.Header;
                sf.Alignment = StringAlignment.Near;
                if (i > 0)
                    rcString.Offset(arrSizes[i - 1], 0);
                rcString.Width = arrSizes[i];
                e.Graphics.FillRectangle(Brushes.LightGray, rcString.Left, rcString.Top, rcString.Width, rcString.Height);
                e.Graphics.DrawRectangle(Pens.Black, rcString.Left, rcString.Top, rcString.Width, rcString.Height);
                e.Graphics.DrawString(str, fnt, Brushes.Black, rcString, sf);
            }
        }

        #endregion
    }
}
