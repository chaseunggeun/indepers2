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

        private void LoadCsv(string drinkFilePath, string optionFilePath)
        {
            // DataSet 초기화
            dataSet = new DataSet1();

            // Drink 테이블 로드
            LoadCsvToTable(drinkFilePath, "Drink");
            // Option 테이블 로드
            LoadCsvToTable(optionFilePath, "Option");

            cmdSheets.Items.Clear();
            cmdSheets.Items.Add("Drink");
            cmdSheets.Items.Add("Option");
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
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = openFileDialog1.FileNames;
                if (fileNames.Length == 2) // 두 개의 파일을 선택했는지 확인
                {
                    string drinkFilePath = fileNames[0];
                    string optionFilePath = fileNames[1];

                    if (File.Exists(drinkFilePath) && File.Exists(optionFilePath))
                    {
                        LoadCsv(drinkFilePath, optionFilePath);
                    }
                    else
                    {
                        MessageBox.Show("유효한 파일 경로를 확인하세요.", "파일 경로 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("두 개의 CSV 파일을 선택하세요.", "파일 선택 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            cmdSheets.SelectedIndexChanged += cmdSheets_SelectedIndexChanged;
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            // SaveFileDialog를 사용하여 사용자가 저장할 경로 선택
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.FileName = "Drink.csv"; // 기본 파일 이름 설정

                // 사용자가 저장 경로를 선택하고 확인을 누를 때
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string saveDirectory = Path.GetDirectoryName(saveFileDialog.FileName);

                    // Drink 테이블을 저장할 파일 경로
                    string drinkFilePath = Path.Combine(saveDirectory, "Drink.csv");
                    // Option 테이블을 저장할 파일 경로
                    string optionFilePath = Path.Combine(saveDirectory, "Option.csv");

                    // Drink 테이블 저장
                    SaveTableToCsv(dataSet.Tables["Drink"], drinkFilePath);
                    // Option 테이블 저장
                    SaveTableToCsv(dataSet.Tables["Option"], optionFilePath);

                    MessageBox.Show("CSV 파일이 저장되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
