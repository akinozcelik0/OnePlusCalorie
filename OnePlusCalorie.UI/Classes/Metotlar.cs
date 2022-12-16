using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePlusCalorie.UI.Classes
{
    public static class Metotlar
    {
        public static bool BosAlanVarMi(GroupBox grp)
        {
            foreach (var item in grp.Controls)
            {
                if (item is TextBox && ((TextBox)item).Text == string.Empty)
                {
                    return true;
                }
                else if (item is MaskedTextBox && ((MaskedTextBox)item).Text == string.Empty)
                {
                    return true;
                }
                else if (item is DateTimePicker && ((DateTimePicker)item).Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    return true;
                }
                else if (item is ComboBox && ((ComboBox)item).SelectedIndex == -1)
                {
                    return true;
                }
            }
            return false;
        }


        public static void Temizle(GroupBox grp)
        {
            foreach (var item in grp.Controls)
            {
                if (item is TextBox) ((TextBox)item).Text = string.Empty;

                else if (item is MaskedTextBox) ((MaskedTextBox)item).Text = string.Empty;

                else if (item is DateTimePicker) ((DateTimePicker)item).Value = DateTime.Now;

                else if (item is ComboBox) ((ComboBox)item).SelectedIndex = -1;

                else if (item is ListBox) ((ListBox)item).DataSource = null;
            }
        }
        public static void HepsiniKapat(GroupBox grp)
        {
            foreach (var item in grp.Controls)
            {
                if (item is TextBox) ((TextBox)item).Enabled = false;

                else if (item is MaskedTextBox) ((MaskedTextBox)item).Enabled = false;

                else if (item is DateTimePicker) ((DateTimePicker)item).Enabled = false;

                else if (item is ComboBox) ((ComboBox)item).Enabled = false;

                else if (item is ListBox) ((ListBox)item).DataSource = null;
            }
        }


        public static void HepsiniAc(GroupBox grp)
        {
            foreach (var item in grp.Controls)
            {
                if (item is TextBox) ((TextBox)item).Enabled = true;

                else if (item is MaskedTextBox) ((MaskedTextBox)item).Enabled = true;

                else if (item is DateTimePicker) ((DateTimePicker)item).Enabled = true;

                else if (item is ComboBox) ((ComboBox)item).Enabled = true;

                
            }
        }


        public static bool BosAlanVarMiPanel(Panel pnl)
        {
            foreach (var item in pnl.Controls)
            {
                if (item is TextBox && ((TextBox)item).Text == string.Empty)
                {
                    return true;
                }
                else if (item is MaskedTextBox && ((MaskedTextBox)item).Text == string.Empty)
                {
                    return true;
                }
                else if (item is DateTimePicker && ((DateTimePicker)item).Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    return true;
                }
                else if (item is ComboBox && ((ComboBox)item).SelectedIndex == -1)
                {
                    return true;
                }
            }
            return false;
        }




    }
}
