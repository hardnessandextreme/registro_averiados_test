using System.Collections;

namespace registro_dañados
{
    internal class MultiColumnComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            DataGridViewRow row1 = (DataGridViewRow)x;
            DataGridViewRow row2 = (DataGridViewRow)y;

            // Comparar por fecha
            int compareResult = DateTime.Compare(Convert.ToDateTime(row1.Cells["FECHA"].Value), Convert.ToDateTime(row2.Cells["FECHA"].Value));
            if (compareResult != 0)
            {
                return compareResult;
            }

            // Comparar por tipo
            compareResult = string.Compare(row1.Cells["TIPO"].Value.ToString(), row2.Cells["TIPO"].Value.ToString());
            if (compareResult != 0)
            {
                return compareResult;
            }

            // Comparar por marca
            compareResult = string.Compare(row1.Cells["MARCA"].Value.ToString(), row2.Cells["MARCA"].Value.ToString());
            if (compareResult != 0)
            {
                return compareResult;
            }

            // Comparar por modelo
            compareResult = string.Compare(row1.Cells["MODELO"].Value.ToString(), row2.Cells["MODELO"].Value.ToString());
            return compareResult;
        }
    }
}