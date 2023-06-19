using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace kursovaya_fordfulkerson
{
    public partial class Form1 : Form
    {
        // класс Worker
        public class Worker
        {
            public string firstName;
            public string lastName;
            public string gender;
            public string[] vacancies;
            public Worker(string firstName, string lastName, string gender, string[] vacancies)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.gender = gender;
                this.vacancies = vacancies;
            }
        }

        public class Vacancy
        {
            public string vacancy;

            public Vacancy(string vacancy)
            {
                this.vacancy = vacancy;
            }
        }

        public class Result
        {
            public string firstName;
            public string lastName;
            public string gender;
            public string vacancy;


            public Result(string firstName, string lastName, string gender, string vacancy)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.gender = gender;
                this.vacancy = vacancy;
            }
        }

        public class Graph
        {
            public int first_amount;
            public int second_amount;
            public Dictionary<int, List<int>> edges;
            public Graph(int first_amount, int second_amount)
            {
                this.first_amount = first_amount;
                this.second_amount = second_amount;
                edges = new Dictionary<int, List<int>>();
            }
            public void add_edge(int x, int y)
            {
                if (this.edges.ContainsKey(x))
                {
                    this.edges[x].Add(y);
                }
                else
                {
                    List<int> new_job = new List<int>();
                    new_job.Add(y);
                    this.edges.Add(x, new_job);
                }
            }
        }

        string[] panels = new string[] { "home", "employees", "addEmployee", "download", "count" };
        List<Worker> workers = new List<Worker>();
        List<string> vacanciesList = new List<string>();
        List<Result> resultList = new List<Result>();
        string openedPanel = "";
        public Form1()
        {
            InitializeComponent();
            // задаем стили
            textBoxFirstName.AutoSize = false;
            textBoxFirstName.Size = new Size(220, 25);

            textBoxLastName.AutoSize = false;
            textBoxLastName.Size = new Size(220, 25);
            
            comboBoxVacancy.FlatStyle = FlatStyle.Flat;

            buttonSubmit.BackColor = SystemColors.Control;

            // скрываем все панели при запуске программы
            panelAdd.Visible = false;
            panelEmployees.Visible = false;
            panelDownload.Visible = false;
            panelResultCount.Visible = false;

            // чтение из файла вакансий и занесение их в combobox
            List<Vacancy> vacancies = new List<Vacancy>();
            using (StreamReader reader = new StreamReader("C:\\Users\\polin\\source\\repos\\kursovaya_fordfulkerson\\vacancies.json"))
            {
                string json = reader.ReadToEnd();
                vacancies = JsonConvert.DeserializeObject<List<Vacancy>>(json);
            }

            for (int i = 0; i< vacancies.Count; i++)
            {
                comboBoxVacancy.Items.Add(vacancies[i].vacancy);
                vacanciesList.Add(vacancies[i].vacancy);
            }

            // объявляем что сейчас открыта панель home
            openedPanel = panels[0];

        }
        public static bool dfs(Graph graph, int x, bool[] visited, int[] assign)
        {
            if (graph.edges.ContainsKey(x))
            {
                foreach (int y in graph.edges[x])
                {
                    if (!visited[y])
                    {
                        visited[y] = true;
                        int assigned_x = assign[y];
                        if (assigned_x < 0 || dfs(graph, assigned_x, visited, assign))
                        {
                            assign[y] = x;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static int[] Matching(Graph graph)
        {
            int first_amount = graph.first_amount;
            int second_amount = graph.second_amount;
            int[] assign = new int[second_amount];
            for (int i = 0; i < second_amount; i++)
                assign[i] = -1;
            int connCount = 0;
            for (int x = 0; x < first_amount; x++)
            {
                bool[] visited = new bool[second_amount];
                if (dfs(graph, x, visited, assign))
                    connCount++;
            }

            return assign;
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFemale.Checked == true)
            {
                checkBoxMale.Checked = false;
            }
        }

        private void checkBoxMale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked == true)
            {
                checkBoxFemale.Checked = false;
            }
        }

        
        // определяем пол по выбранному чекбоксу, если ни один не выбран, возвращаем пустую строку
        public string detectGender()
        {

            if (checkBoxFemale.Checked)
            {
                return "женский";
            }

            if (checkBoxMale.Checked)
            {
                return "мужской";
            }

            return "";
        }

        // при нажатии "Добавить" создаем экземпляр класса Worker и добавляем в массив workers
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            workers.Add(new Worker(textBoxFirstName.Text, textBoxLastName.Text, detectGender(), labelAddedVacancy.Text.Trim().Split()));
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelAddedVacancy.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            checkBoxMale.Checked = false;
            checkBoxFemale.Checked = false;
            comboBoxVacancy.SelectedIndex = -1;
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            handlePanelsOpening();
            labelNotification.Text = "";
            openedPanel = panels[3];
            if (workers.Count == 0)
            {
                buttonDownloadEmployees.Enabled = false;
            } else
            {
                buttonDownloadEmployees.Enabled = true;
            }
            if (resultList.Count == 0)
            {
                buttonDownloadCount.Enabled = false;
            } else
            {
                buttonDownloadCount.Enabled = true;

            }
            panelDownload.Visible = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            handlePanelsOpening();

            openedPanel = panels[2];

            panelAdd.Visible = true;
        }

        // закрывает текущую панель
        private void handlePanelsOpening()
        {
            switch (openedPanel)
            {
                case "employees":
                    panelEmployees.Visible = false;
                    dataGridViewEmployees.Rows.Clear();
                    break;
                case "addEmployee":
                    labelAddedVacancy.Text = "";
                    panelAdd.Visible = false;
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    comboBoxVacancy.SelectedIndex = -1;
                    break;
                case "download":
                    panelDownload.Visible = false;
                    break;
                case "count":
                    panelResultCount.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void checkIsNotEmpty()
        {
            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && labelAddedVacancy.Text != "")
            {
                buttonSubmit.Enabled = true;
            } else
            {
                buttonSubmit.Enabled = false;
            }
        }

        // при нажатии кнопки "Работники" заполняем dataGridView данными из массива workers 
        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            handlePanelsOpening();

            openedPanel = panels[1];

            panelEmployees.Visible = true;

            for (int i = 0; i < workers.Count; i++)
            {
                for (int j = 0; j < workers[i].vacancies.Length; j++)
                {
                    dataGridViewEmployees.Rows.Add(workers[i].firstName, workers[i].lastName, workers[i].gender, workers[i].vacancies[j]);
                }
            }

        }

        private void buttonSubmit_EnabledChanged(object sender, EventArgs e)
        {
            if (buttonSubmit.Enabled == false)
            {
                buttonSubmit.BackColor = SystemColors.Control;
            } else
            {
                buttonSubmit.BackColor = Color.Teal;
            }
        }

        private void buttonDownloadCount_EnabledChanged(object sender, EventArgs e)
        {
            if (buttonDownloadCount.Enabled == false)
            {
                buttonDownloadCount.BackColor = SystemColors.Control;
            }
            else
            {
                buttonDownloadCount.BackColor = Color.Teal;
            }
        }

        private void buttonDownloadEmployees_EnabledChanged(object sender, EventArgs e)
        {
            if (buttonDownloadEmployees.Enabled == false)
            {
                buttonDownloadEmployees.BackColor = SystemColors.Control;
            }
            else
            {
                buttonDownloadEmployees.BackColor = Color.Teal;
            }
        }

        private void buttonResults_EnabledChanged(object sender, EventArgs e)
        {
            if (buttonResults.Enabled == false)
            {
                buttonResults.BackColor = SystemColors.Control;
            }
            else
            {
                buttonResults.BackColor = Color.Teal;
            }
        }

        private void comboBoxVacancy_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIsNotEmpty();
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            checkIsNotEmpty();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            checkIsNotEmpty();
        }

        private void buttonDownloadCount_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        JsonSerializer serializer = new JsonSerializer();

                        using (StreamWriter sw = new StreamWriter(fbd.SelectedPath + "\\result.json"))
                        using (JsonWriter writer = new JsonTextWriter(sw))
                        {
                            serializer.Serialize(writer, resultList);
                        }


                        labelNotification.Text = "Выгрузка прошла успешно по пути " + fbd.SelectedPath + "\\result.json";
                    }
                }

            } catch
            {
                labelNotification.Text = "Произошла ошибка.";
            }

        }

        // выгрузка данных о работниках в файл
        private void buttonDownloadEmployees_Click(object sender, EventArgs e)
        {
            try
            {

                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        JsonSerializer serializer = new JsonSerializer();

                        using (StreamWriter sw = new StreamWriter(fbd.SelectedPath + "\\workers.json"))
                        using (JsonWriter writer = new JsonTextWriter(sw))
                        {
                            serializer.Serialize(writer, workers);
                        }

                        labelNotification.Text = "Выгрузка прошла успешно по пути " + fbd.SelectedPath + "\\workers.json";
                    }
                }
            } catch
                {
                    labelNotification.Text = "Произошла ошибка.";
                }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Json Files (*.json)|*.json";

            string path = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;

                List<Worker> importedWorkers = new List<Worker>();

                using (StreamReader reader = new StreamReader(path))
                {
                    string json = reader.ReadToEnd();
                    importedWorkers = JsonConvert.DeserializeObject<List<Worker>>(json);
                }

                for (int i = 0; i < importedWorkers.Count; i++)
                {
                    workers.Add(importedWorkers[i]);
                    for (int j =0; j < importedWorkers[i].vacancies.Length; j++)
                    {
                        dataGridViewEmployees.Rows.Add(importedWorkers[i].firstName, importedWorkers[i].lastName, importedWorkers[i].gender, importedWorkers[i].vacancies[j]);
                    }
                }
            }

        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            handlePanelsOpening();
            openedPanel = panels[4];
            if (workers.Count == 0)
            {
                buttonResults.Enabled = false;
            } else
            {
                buttonResults.Enabled = true;
            }

            panelResultCount.Visible = true;
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            resultList = new List<Result>();
            dataGridViewResults.Rows.Clear();

            Graph graph = new Graph(workers.Count, vacanciesList.Count);

            List<int[]> tempList = new List<int[]>(); 

            for (int i = 0; i < workers.Count; i++)
            {

                for (int d = 0; d < workers[i].vacancies.Length; d++)
                {
                    int[] tempArr = new int[2];
                    tempArr[0] = i;

                    for (int j = 0; j < vacanciesList.Count; j++)
                    {
                        if (vacanciesList[j] == workers[i].vacancies[d])
                        {
                            tempArr[1] = j;
                        }
                    }

                    tempList.Add(tempArr);
                }

            }

            for (int i = 0; i < tempList.Count; i++)
            {
                graph.add_edge(tempList[i][0], tempList[i][1]);
            }

            int[] result = Matching(graph);

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != -1)
                {
                    resultList.Add(new Result(workers[result[i]].firstName, workers[result[i]].lastName, workers[result[i]].gender, vacanciesList[i]));
                    dataGridViewResults.Rows.Add(result[i], workers[result[i]].firstName, vacanciesList[i]);

                }
            }
        }

        private void buttonClearEmployees_Click(object sender, EventArgs e)
        {
            workers.Clear();
            dataGridViewEmployees.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelAddedVacancy.Text.Split().Length < 4)
            {
                if (!Array.Exists(labelAddedVacancy.Text.Trim().Split(), element => element == comboBoxVacancy.Text))
                {
                    labelAddedVacancy.Text += comboBoxVacancy.Text + " ";
                }
            }

            if (labelAddedVacancy.Text.Trim().Split().Length == 4)
            {
                button1.Enabled = false;
            }

            checkIsNotEmpty();

        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                button1.BackColor = SystemColors.Control;
            }
            else
            {
                button1.BackColor = Color.Teal;
            }
        }
    }
}
