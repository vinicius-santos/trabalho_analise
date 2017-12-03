﻿using br.com.vinicius.projeto.analise.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace br.com.vinicius.projeto.analise.Forms
{
    public partial class FolhaForm : Form
    {
        public FolhaForm()
        {
            InitializeComponent();
            bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            var register = new CaixaRegister();
            var records = register.SelectAll();
            var amostra = records.Select(x => new Amostra
            {
                Id = Convert.ToInt32(x.Where(y => y.Key == "Id").FirstOrDefault().Value),
                Complemento = (string)x.Where(y => y.Key == "Complemento").FirstOrDefault().Value,
                GeoReferencia = (string)x.Where(y => y.Key == "GeoReferencia").FirstOrDefault().Value,
                IdCliente = (int)x.Where(y => y.Key == "IdCliente").FirstOrDefault().Value,
                IdSolicitante = Convert.ToInt32(x.Where(y => y.Key == "IdSolicitante").FirstOrDefault().Value),
                Status = (string)(x.Where(y => y.Key == "Status").FirstOrDefault().Value),
                TipoAnalise = (string)(x.Where(y => y.Key == "TipoAnalise").FirstOrDefault().Value),
            });

            List<FolhaBase> folhaList = new List<FolhaBase>();
            var count = 1;
            foreach (var item in amostra)
            {
                FolhaBase folha = new FolhaBase();
                folha.Numero = count;
                folha.IdTipo = item.Id + "/" + item.TipoAnalise;
                folhaList.Add(folha);
                count++;
            }
            var dataTable = CreateDataTable(folhaList);

            foreach (DataColumn dc in dataTable.Columns)
            {
                AddColumns(dc);
            }
            foreach (DataRow dc in dataTable.Rows)
            {
                AddRows(dc);
            }

            count = 0;
            count = DisableCell(count, dataTable);

            dataGridView1.Refresh();
        }

        private void AddRows(DataRow dc)
        {
            dataGridView1.Rows.Add(dc.ItemArray);
        }

        private void AddColumns(DataColumn dc)
        {
            var c = new DataGridViewTextBoxColumn() { HeaderText = dc.ColumnName };
            dataGridView1.Columns.Add(c);
        }

        private int DisableCell(int count, DataTable dataTable)
        {
            foreach (DataRow dc in dataTable.Rows)
            {
                if (dc["idTipo"].ToString().Contains("B1 - Básica"))
                {
                    //dataGridView1.Rows[count].ReadOnly = true;
                    dataGridView1.Rows[count].Cells[12].ReadOnly = true;
                    dataGridView1.Rows[count].Cells[12].Style.BackColor = Color.Gray;
                    dataGridView1.Rows[count].Cells[13].ReadOnly = true;
                    dataGridView1.Rows[count].Cells[13].Style.BackColor = Color.Gray;
                    dataGridView1.Rows[count].Cells[14].ReadOnly = true;
                    dataGridView1.Rows[count].Cells[14].Style.BackColor = Color.Gray;
                    dataGridView1.Rows[count].Cells[15].ReadOnly = true;
                    dataGridView1.Rows[count].Cells[15].Style.BackColor = Color.Gray;
                    dataGridView1.Rows[count].Cells[16].ReadOnly = true;
                    dataGridView1.Rows[count].Cells[16].Style.BackColor = Color.Gray;
                    dataGridView1.Rows[count].Cells[17].ReadOnly = true;
                    dataGridView1.Rows[count].Cells[17].Style.BackColor = Color.Gray;
                    dataGridView1.Rows[count].Cells[18].ReadOnly = true;
                    dataGridView1.Rows[count].Cells[18].Style.BackColor = Color.Gray;
                }
                else if (dc["idTipo"].ToString().Contains("E5 - Completa + S + P - Resina"))
                {
                    dataGridView1.Rows[count].Cells[18].ReadOnly = true;
                    dataGridView1.Rows[count].Cells[18].Style.BackColor = Color.Gray;
                }
                else if (dc["idTipo"].ToString().Contains("E4 - Completa + S + B"))
                {
                    dataGridView1.Rows[count].Cells[17].ReadOnly = true;
                    dataGridView1.Rows[count].Cells[17].Style.BackColor = Color.Gray;
                }
                count++;
            }

            return count;
        }

        public static DataTable CreateDataTable<T>(IEnumerable<T> list)
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            DataTable dataTable = new DataTable();
            foreach (PropertyInfo info in properties)
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in list)
            {
                object[] values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(entity);
                }

                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void CreatePDf()
        {
            string outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Sample.pdf");

            //Create a standard .Net FileStream for the file, setting various flags
            using (FileStream fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //Create a new PDF document setting the size to A4
                using (Document doc = new Document(PageSize.A4))
                {
                    //Bind the PDF document to the FileStream using an iTextSharp PdfWriter
                    using (PdfWriter w = PdfWriter.GetInstance(doc, fs))
                    {
                        //Open the document for writing
                        doc.Open();
                        //Create a table with two columns
                        PdfPTable t = new PdfPTable(2);
                        //Borders are drawn by the individual cells, not the table itself.
                        //Tell the default cell that we do not want a border drawn
                        t.DefaultCell.Border = 0;
                        //Add four cells. Cells are added starting at the top left of the table working left to right first, then down
                        t.AddCell("R1C1");
                        t.AddCell("R1C2");
                        t.AddCell("R2C1");
                        t.AddCell("R2C2");
                        //Add the table to our document
                        doc.Add(t);
                        //Close our document
                        doc.Close();
                    }
                }
            }

            this.Close();
        }
    }
}
