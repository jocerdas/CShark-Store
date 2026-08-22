using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CapaUI
{
    public static class comboHelper
    {
        public static void CargarCombo<T>(
            ComboBox combo,
            List<T> datos,
            string displayMember,
            string valueMember,
            string textoDefecto = "-- Seleccione --")
        {
            combo.DataSource = null;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;

            if (!string.IsNullOrEmpty(textoDefecto))
            {
                var itemDefecto = Activator.CreateInstance<T>();
                PropertyInfo propTexto = typeof(T).GetProperty(displayMember);
                PropertyInfo propValor = typeof(T).GetProperty(valueMember);

                if (propTexto != null && propValor != null)
                {
                    propTexto.SetValue(itemDefecto, textoDefecto);
                    propValor.SetValue(itemDefecto, 0);
                    datos.Insert(0, itemDefecto);
                }
            }

            combo.DataSource = datos;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            combo.SelectedIndex = 0;
        }

        public static T ObtenerSeleccionado<T>(ComboBox combo) where T : class
        {
            return combo.SelectedItem as T;
        }
    }
}
