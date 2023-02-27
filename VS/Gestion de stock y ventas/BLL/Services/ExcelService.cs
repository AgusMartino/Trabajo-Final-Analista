using ExcelDataReader;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL.Services
{
    public sealed class ExcelService
    {
        #region Singleton
        private readonly static ExcelService _instance = new ExcelService();

        public static ExcelService Current
        {
            get
            {
                return _instance;
            }
        }

        private ExcelService()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
        private DataSet dts = new DataSet();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listado"></param>
        /// <returns></returns>
        public void ExportExcel(List<string> listado)
        {
            try
            {
                string path = "";
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = @"C:\";
                var diag = saveFileDialog.ShowDialog();
                if (diag == DialogResult.OK)
                {
                    path = saveFileDialog.FileName;
                    using (SLDocument sl = new SLDocument())
                    {
                        int i = 1;
                        foreach (var Head in listado)
                        {
                            sl.SetCellValue(1, i, Head);
                            i++;
                        }
                        path = path + DateTime.Now.ToString("ddMMyyHHmmss") + ".xlsx";
                        sl.SaveAs(path);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public DataSet ImportExcel(DataGridView Dtg, TextBox Txt)
        {
            try
            {
                Dtg = new DataGridView();
                Txt = new TextBox();
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Excel Worbook|*.xlsx";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Dtg.DataSource = null;
                    Txt.Text = openFileDialog1.FileName;

                    FileStream fsSource = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateReader(fsSource);

                    dts = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dts;
        }
    }
}

