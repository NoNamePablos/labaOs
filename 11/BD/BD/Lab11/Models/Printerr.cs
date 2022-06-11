using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11.Models
{
    public static class Printerr
    {
        public static void PrintMultiLineData(this ListView lvw,
            Point location, Graphics gr,
            Brush header_brush, Brush data_brush, Pen grid_pen)
        {
            const int x_margin = 5;
            const int y_margin = 3;
            float x = location.X;
            float y = location.Y;

            // Получите горизонтальное разрешение экрана.
            float screen_res_x;
            using (Graphics screen_gr = lvw.CreateGraphics())
            {
                screen_res_x = screen_gr.DpiX;
            }

            // Коэффициент масштабирования для преобразования из пикселов экрана
            // к единицам печати (100 дюймов дюймов)
            float screen_to_printer = 100 / screen_res_x;

            // Получите ширину столбцов в единицах принтера.
            float[] col_wids = new float[lvw.Columns.Count];
            for (int i = 0; i < lvw.Columns.Count; i++)
                col_wids[i] = (lvw.Columns[i].Width + 2 * x_margin) *
                    screen_to_printer;

            int num_columns = lvw.Columns.Count;
            using (StringFormat string_format = new StringFormat())
            {
                // Нарисуйте заголовки столбцов.
                string_format.Alignment = StringAlignment.Center;
                string_format.LineAlignment = StringAlignment.Center;
                var header_query =
                    from ColumnHeader column in lvw.Columns
                    select column.Text;
                DrawMultiLineItems(header_query.ToArray(),
                    gr, lvw.Font, header_brush, grid_pen,
                    x_margin, y_margin,
                    x, ref y, col_wids, num_columns, string_format);

                // Нарисуйте данные.
                string_format.Alignment = StringAlignment.Near;
                int xz = lvw.Items.Count;
                int dsd=1;
                dsd = 1;
                foreach (ListViewItem item in lvw.Items)
                {


                    var subitems_query =
                        from ListViewItem.ListViewSubItem subitem
                        in item.SubItems
                        select subitem.Text;
                    DrawMultiLineItems(subitems_query.ToArray(),
                        gr, lvw.Font, data_brush, grid_pen,
                        x_margin, y_margin,
                        x, ref y, col_wids, num_columns, string_format);
                }
            }
        }

        private static void DrawMultiLineItems(string[] items,
     Graphics gr, Font lvw_font, Brush header_brush, Pen grid_pen,
     float x_margin, float y_margin, float x0, ref float y0,
     float[] col_wids, int num_columns, StringFormat string_format)
        {
            float row_height = 0;
            float x = x0;
            for (int i = 0; i < num_columns; i++)
            {
                // Измерьте размер, необходимый для текста.
                float text_width = col_wids[i] - 2 * x_margin;
                SizeF layout_area = new SizeF(col_wids[i], 1000);
                SizeF row_size =
                    gr.MeasureString(items[i], lvw_font, layout_area);
                if (row_height < row_size.Height) row_height = row_size.Height;

                // Нарисуйте текст.
                RectangleF rect = new RectangleF(
                    x + x_margin, y0 + y_margin,
                    text_width, row_size.Height);
                gr.DrawString(items[i], lvw_font,
                    header_brush, rect, string_format);

                // Нарисуйте следующий столбец.
                x += col_wids[i];
            }

            // Добавьте дополнительную комнату для вертикального края.
            row_height += 2 * y_margin;

            // Нарисуйте прямоугольники вокруг заголовков столбцов.
            x = x0;
            for (int i = 0; i < num_columns; i++)
            {
                //Нарисуйте коробку.
                RectangleF rect = new RectangleF(
                    x, y0, col_wids[i], row_height);
                gr.DrawRectangle(grid_pen, Rectangle.Round(rect));

                // Draw the next column.
                x += col_wids[i];
            }

            // Подготовьтесь к следующей строке.
            y0 += row_height;
        }
        public static void DrawRectangle(this Graphics gr, Pen pen,
    RectangleF rectf)
        {
            gr.DrawRectangle(pen,
                rectf.Left, rectf.Top, rectf.Width, rectf.Height);
        }
    }
}
