using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private DataSet1 dataSet;

        public Form2()
        {
            InitializeComponent();
        }

        private void LoadCsv()
        {
            // DataSet 초기화
            dataSet = new DataSet1();

            // Drink 테이블 로드
            string csvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Drink.csv");
            LoadCsvToTable(csvFilePath, "Drink");

            cmdSheets.Items.Clear();
            cmdSheets.Items.Add("Drink");
            cmdSheets.SelectedIndex = 0;
        }


        private void LoadCsvToTable(string filePath, string tableName)
        {
            var table = dataSet.Tables[tableName];

            using (var reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                if (line == null) return;

                // 컬럼 이름 가져오기
                var columns = line.Split(',');

                // 데이터 로드
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');

                    // LINQ를 사용하여 DataRow 생성 및 값 할당
                    var newRow = table.NewRow();
                    columns.Select((col, index) =>
                    {
                        newRow[col] = values[index];
                        return true;
                    }).ToArray();
                    table.Rows.Add(newRow);
                }
            }
        }


        private void SaveTableToCsv(DataTable table, string filePath)
        {
            var lines = new List<string>();

            // 컬럼 이름 추가
            string[] columnNames = table.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
            var header = string.Join(",", columnNames);
            lines.Add(header);

            // 데이터 추가
            var valueLines = table.AsEnumerable()
                .Select(row => string.Join(",", row.ItemArray.Select(val => val.ToString())));
            lines.AddRange(valueLines);

            // 파일에 쓰기 (UTF-8 형식으로 인코딩)
            File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadCsv();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            cmdSheets.SelectedIndexChanged += cmdSheets_SelectedIndexChanged;
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            // Drink 테이블을 저장할 파일 경로
            string drinkFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Drink.csv");

            // Drink 테이블 저장
            SaveTableToCsv(dataSet.Tables["Drink"], drinkFilePath);

            MessageBox.Show("CSV 파일이 저장되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void cmdSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataSet != null && cmdSheets.SelectedItem != null)
            {
                dataGridView1.DataSource = dataSet.Tables[cmdSheets.SelectedItem.ToString()];
            }
        }
    }
}
