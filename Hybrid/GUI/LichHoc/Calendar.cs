using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.LichHoc
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
            GenerateCalendar(DateTime.Now.Month, DateTime.Now.Year);
        }


        public void GenerateCalendar(int month, int year)
        {
            clearCalendar();

            int daysInMonth = DateTime.DaysInMonth(year, month);
            DateTime firstDayOfMonth = new DateTime(year, month, 1);

            KryptonButton[] dayButton = new KryptonButton[daysInMonth];
            dayButton[0] = new KryptonButton
            {
                Text = "1",
                Size = new System.Drawing.Size(44, 46)
            };
            dayButton[0].StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            dayButton[0].StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            dayButton[0].StateCommon.Border.Color1 = System.Drawing.SystemColors.Control;
            dayButton[0].StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            dayButton[0].StateTracking.Back.Color1 = System.Drawing.Color.Teal;
            dayButton[0].StateTracking.Back.Color2 = System.Drawing.Color.Teal;
            dayButton[0].StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;

            switch (firstDayOfMonth.DayOfWeek.ToString())
            {
                case "Monday":
                    calendarTbl.Controls.Add(dayButton[0], 0, 0);
                    fillInDayInMonth(dayButton, 1, 0, daysInMonth);
                    break;
                case "Tuesday":
                    calendarTbl.Controls.Add(dayButton[0], 1, 0);
                    break;
                case "Wednesday":
                    calendarTbl.Controls.Add(dayButton[0], 2, 0);
                    break;
                case "Thursday":
                    calendarTbl.Controls.Add(dayButton[0], 3, 0);
                    break;
                case "Friday":
                    calendarTbl.Controls.Add(dayButton[0], 4, 0);
                    break;
                case "Saturday":
                    calendarTbl.Controls.Add(dayButton[0], 5, 0);
                    break;
                case "Sunday":
                    calendarTbl.Controls.Add(dayButton[0], 6, 0);
                    fillInDayInMonth(dayButton, 0,1, daysInMonth);
                    break;
            }

        }

        private void fillInDayInMonth(KryptonButton[] dayButton, int colStart, int rowStart, int daysInMonth)
        {
            int days = 2;
            while (days <= daysInMonth)
            {

                dayButton[days - 1] = new KryptonButton
                {
                    Text = days.ToString(),
                    Size = new System.Drawing.Size(44, 46)
            };
                dayButton[days - 1].StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
                dayButton[days - 1].StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
                dayButton[days - 1].StateCommon.Border.Color1 = System.Drawing.SystemColors.Control;
                dayButton[days - 1].StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                dayButton[days - 1].StateTracking.Back.Color1 = System.Drawing.Color.Teal;
                dayButton[days - 1].StateTracking.Back.Color2 = System.Drawing.Color.Teal;
                dayButton[days - 1].StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
                calendarTbl.Controls.Add(dayButton[days - 1], colStart, rowStart);
                days++;
                colStart++;
                if (colStart >= 7)
                {
                    rowStart++;
                    colStart = 0;
                }
            }
        }

        private void clearCalendar()
        {
            calendarTbl.Controls.Clear();
        }
    }
}
