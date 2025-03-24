using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace talYBProj.IFS
{
    internal class Utils
    {
        #region constVar

        private static bool sortDirection = true;
 
        #endregion
        #region messages

        public static void addSuccessMessage()

        {

            System.Windows.Forms.MessageBox.Show("התווסף בהצלחה");

        }

        public static void updateSuccessMessage()

        {

            System.Windows.Forms.MessageBox.Show("עודכן בהצלחה");

        }

        public static void DBErrorMessage()

        {

            System.Windows.Forms.MessageBox.Show("שגיאה בבסיס הנתונים");

        }



        #endregion
        #region validation functions



        /// <summary>

        /// This function check if the string str has only letters

        /// if not the TextBox will show error in the ErrorProvider

        /// </summary>

        /// <param name="str">string to check</param>

        /// <param name="txb">TextBox to check</param>

        /// <param name="ep">Current ErrorProvider</param>

        /// <param name="error">Error Message</param>



        /// <returns></returns>

        public static bool validateName(string str, System.Windows.Forms.TextBox txb, ErrorProvider ep, string error)

        {

            bool status = true;



            if (str.Any(x => Char.IsDigit(x)))

                status = false;



            if (status)

            {

                ep.SetError(txb, "");

            }

            else

            {

                ep.SetError(txb, error);

            }

            return status;

        }

     
      
        /// <summary>

        /// This function check if the string str length between minLen to maxLen

        /// if not the TextBox will show error in the ErrorProvider

        /// </summary>

        /// <param name="str"></param>

        /// <param name="txb"></param>

        /// <param name="ep"></param>

        /// <param name="error"></param>

        /// <param name="minLen"></param>

        /// <param name="maxLen"></param>

        /// <returns></returns>

        public static bool validateStringLength(string str, TextBox txb, ErrorProvider ep, string error, int minLen, int maxLen)

        {

            bool status = true;

            if (str.Length < minLen || str.Length > maxLen)

                status = false;

            if (status)

            {

                ep.SetError(txb, "");

            }

            else

            {

                ep.SetError(txb, error);

            }

            return status;

        }

        /// <summary>

        /// This function check if the string str length between minLen to maxLen

        /// if not the TextBox will show error in the ErrorProvider

        /// </summary>

        /// <param name="str"></param>

        /// <param name="txb"></param>

        /// <param name="ep"></param>

        /// <param name="error"></param>

        /// <param name="minLen"></param>

        /// <param name="maxLen"></param>

        /// <returns></returns>
        #endregion
        #region conversion functions

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)

        {

            using (var ms = new MemoryStream())

            {

                imageIn.Save(ms, imageIn.RawFormat);

                return ms.ToArray();

            }

        }

        public static System.Drawing.Image byteArrayToImage(byte[] bytesArr)

        {

            using (MemoryStream memstr = new MemoryStream(bytesArr))

            {

                System.Drawing.Image img = System.Drawing.Image.FromStream(memstr);

                return img;

            }

        }



        #endregion
        #region misc functions (sort…)



        public static List<T> sortDGV<T>(DataGridView dgv, List<T> lst, DataGridViewCellMouseEventArgs e)

        {

            var dataGrid = (DataGridView)dgv;

            var colName = dataGrid.Columns[e.ColumnIndex].DataPropertyName;

            lst = ((IEnumerable)dataGrid.DataSource).Cast<T>().ToList();

            sortDirection = !sortDirection;



            if (sortDirection)

            {

                lst = lst.OrderBy(item => item.GetType().GetProperty(colName)?.GetValue(item, null)).ToList();

            }

            else

            {

                lst = lst.OrderByDescending(item => item.GetType().GetProperty(colName)?.GetValue(item, null)).ToList();

            }

            dataGrid.DataSource = lst;

            return lst;

        }

        #endregion


    }
}
